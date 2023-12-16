using System;
using System.Numerics;

namespace LatticeCryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            // กำหนดค่าพารามิเตอร์การเข้ารหัส
            int modulusSize = 4096;
            int latticeDimension = 100;
            int errorRate = 0.001;

            // สร้างตาข่าย
            var lattice = new Lattice(modulusSize, latticeDimension);

            // สร้างรหัสลับ
            var secretKey = lattice.GenerateSecretKey();

            // แปลงข้อความ "สวัสดี ชาวโลก" เป็นจุดในตาข่าย
            var message = "สวัสดี ชาวโลก";
            var messageVector = lattice.Encode(message);

            // เข้ารหัสข้อความ
            var ciphertext = lattice.Encrypt(messageVector, secretKey);

            // ถอดรหัสข้อความ
            var plaintext = lattice.Decrypt(ciphertext, secretKey);

            // แสดงข้อความที่ถอดรหัสได้
            Console.WriteLine(plaintext);
        }
    }
}
