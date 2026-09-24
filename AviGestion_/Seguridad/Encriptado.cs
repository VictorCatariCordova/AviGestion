using System;
using System.Security.Cryptography;
using System.Text;

namespace AviGestion_.Seguridad
{
    // Utilidad de cifrado para datos sensibles (CU-09).
    // - HashSHA256: para contraseñas (irreversible, es la práctica recomendada).
    // - Encriptar/Desencriptar (AES): para datos que sí necesitan poder leerse de nuevo
    //   (ej: DNI/CUIL de clientes, teléfonos, datos financieros).
    public static class Encriptado
    {
        // TODO para producción real: esta clave debería salir de un archivo de configuración
        // protegido (App.config con sección encriptada), no hardcodeada en el código fuente.
        private static readonly byte[] Llave = Encoding.UTF8.GetBytes("AviGestion2026KeySeguridad!!1234");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("AviGestionIV2026");

        public static string HashSHA256(string textoPlano)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public static string Encriptar(string textoPlano)
        {
            if (string.IsNullOrEmpty(textoPlano)) return textoPlano;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Llave.Length == 32 ? Llave : ResizeKey(Llave, 32);
                aes.IV = IV.Length == 16 ? IV : ResizeKey(IV, 16);

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] datos = Encoding.UTF8.GetBytes(textoPlano);
                    byte[] resultado = encryptor.TransformFinalBlock(datos, 0, datos.Length);
                    return Convert.ToBase64String(resultado);
                }
            }
        }

        public static string Desencriptar(string textoCifrado)
        {
            if (string.IsNullOrEmpty(textoCifrado)) return textoCifrado;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Llave.Length == 32 ? Llave : ResizeKey(Llave, 32);
                aes.IV = IV.Length == 16 ? IV : ResizeKey(IV, 16);

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] datos = Convert.FromBase64String(textoCifrado);
                    byte[] resultado = decryptor.TransformFinalBlock(datos, 0, datos.Length);
                    return Encoding.UTF8.GetString(resultado);
                }
            }
        }

        private static byte[] ResizeKey(byte[] original, int tamano)
        {
            byte[] destino = new byte[tamano];
            Array.Copy(original, destino, Math.Min(original.Length, tamano));
            return destino;
        }
    }
}