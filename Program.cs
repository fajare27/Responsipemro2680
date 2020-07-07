using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectCustomer2680
{

    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah costumer");
            Console.WriteLine("2. Hapus costumer");
            Console.WriteLine("3. Tampilkan costumer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection
            Console.WriteLine();
            Console.WriteLine("Tambah Data costumer\n");
            Customer customer = new Customer();
            Console.Write("Kode Costumer : ");
            customer.customercode = Console.ReadLine();
            Console.Write("Nama Costumer : ");
            customer.customername = Console.ReadLine();
            Console.Write("Jumlah Piutang  : ");
            customer.piutang = Convert.ToDouble(Console.ReadLine());
            daftarCustomer.Add(customer);
            Console.WriteLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Costumer\n");
            Console.Write("Kode Costumer : ");
            string code = Console.ReadLine();
            foreach (Customer customer in daftarCustomer)
            {
                no++;
                if (customer.customercode == code)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarCustomer.RemoveAt(hapus);
                Console.WriteLine("\nData Costumer Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Costumer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection
            int noUrut = 0;
            Console.WriteLine("Data Costumer\n");
            foreach (Customer customer in daftarCustomer)
            {
                noUrut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}", noUrut, customer.customercode, customer.customername, customer.piutang);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Costumer Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}