package tiket.pesawat;

import java.io.*;

public class TiketPesawat {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int[] hargajkt = new int[2];
        hargajkt[0] = 700000;
        hargajkt[1] = 1000000;
        int[] hargabdg = new int[2];
        hargabdg[0] = 900000;
        hargabdg[1] = 1200000;
        int [] hargabali = new int [2];
        hargabali[0] = 350000;
        hargabali[1] = 550000;
        int [] hargamdn = new int [2];
        hargamdn[0] = 1500000;
        hargamdn[1] = 2000000;
        String user, pass, tgl, bln, thn;
        int pilihan, bagasi, bagasi1, pilihanjm, penumpang;
        int a = 0;
        int b = 0;

        String pilih_bandara = "";
        int[] harga_asaltujuan = new int[10];
        
        for (int i = 3; i > 0; i--) {
            System.out.print("Masukan user    : ");
            user = br.readLine();
            System.out.print("Masukan Pasword : ");
            pass = br.readLine();
            if(i == 1){
                System.out.print("Gagal Login 3x ");
                return;
            }
            if (user.equalsIgnoreCase("admin") && pass.equalsIgnoreCase("123")) {
                System.out.println("Login anda Berhasil ");
                break;
            }
            else{
                System.out.println("Maaf username atau pasword anda salah");
                System.out.println("Coba lagi, Tersisa " + (i-1));
            }

        }

        System.out.println("=================== Tanggal Keberangkatan ==================");
        System.out.print("Masukan Tanggal = ");
        tgl = br.readLine();
        System.out.print("Masukan Bulan = ");
        bln = br.readLine();
        System.out.print("Masukan Tahun = ");
        thn = br.readLine();
        do {
            System.out.println("======================= Tiket Pesawat =======================");
            System.out.println(" " + tgl + "-" + bln + "-" + thn);
            System.out.println(" Selamat Datang di Bandara Juanda Surabaya ");
            System.out.println(" 1. Bandara Juanda Surabaya --> Sukarno hatta (Jakarta)");
            System.out.println(" 2. Bandara Juanda Surabaya --> Halim Perdana Kusuma (Bandung)");
            System.out.println(" 3. Bandara Juanda Surabaya --> Ngurah Rai (Bali)");
            System.out.println(" 4. Bandara Juanda Surabaya --> Kualanamu (Medan)");
            System.out.print("Masukan tujuan anda : ");
            pilihan = Integer.parseInt(br.readLine());
            switch (pilihan) {
                case 1:
                    //1. Bandara Juanda Surabaya --> Sukarno hatta (Jakarta)
                    pilih_bandara   = "Bandara Juanda Surabaya --> Sukarno hatta (Jakarta)";
                    harga_asaltujuan[0]    =  hargajkt[0];
                    harga_asaltujuan[1]    =  hargajkt[1];
                    // System.out.println("1. 07:00-09:00 = Rp.   700.000");
                    // System.out.println("2. 16:00-18:00 = Rp. 1.000.000");
                    break;

                case 2:
                    pilih_bandara   = "Bandara Juanda Surabaya --> Halim Perdana Kusuma (Bandung)";
                    harga_asaltujuan[0]    =  hargabdg[0];
                    harga_asaltujuan[1]    =  hargabdg[1];
                    // System.out.println("1. 07:00-09:00 = Rp.   900.000");
                    // System.out.println("2. 16:00-18:00 = Rp. 1.200.000");
                    break;
                    
                case 3:
                    pilih_bandara   = "Bandara Juanda Surabaya --> Ngurah Rai (Bali)";
                    harga_asaltujuan[0]    =  hargabali[0];
                    harga_asaltujuan[1]    =  hargabali[1];
                    // System.out.println("1. 07:00-09:00 = Rp. 350.000");
                    // System.out.println("2. 16:00-18:00 = Rp. 550.000");
                    
                    break;
                    
                case 4:
                    pilih_bandara   = "Bandara Juanda Surabaya --> Kualanamu (Medan)";
                    harga_asaltujuan[0]    =  hargamdn[0];
                    harga_asaltujuan[1]    =  hargamdn[1];
                    // System.out.println("1. 07:00-09:00 = Rp. 1.500.000");
                    // System.out.println("2. 16:00-18:00 = Rp. 2.000.000");
                    
                    break;
                default :

                    break;

            }
            if(pilihan >= 1 && pilihan <= 4){
                System.out.println("");
                System.out.println("======================= Tiket Pesawat =======================");
                System.out.println("Pilihan anda : ");
                System.out.println(pilih_bandara);
                System.out.println(tgl + "-" + bln + "-" + thn);
                System.out.println("Harga Tiket :");

                System.out.println("1. 07:00-09:00 = Rp. " + harga_asaltujuan[0]);
                System.out.println("1. 16:00-18:00 = Rp. " + harga_asaltujuan[1]);

                System.out.print("Pilih jadwal keberangkatan = ");
                pilihanjm = Integer.parseInt(br.readLine());
                System.out.print("Jumlah tiket yang ingin anda beli = ");
                penumpang = Integer.parseInt(br.readLine());
                if (pilihanjm == 1) {
                    a = harga_asaltujuan[0] * penumpang;
                }else{
                    a = harga_asaltujuan[1] * penumpang;
                }
                System.out.print("Masukan Berat bagasi anda (KG): ");
                bagasi = Integer.parseInt(br.readLine());
                bagasi1 = bagasi * 20000;
                b = bagasi1 + a;
                System.out.println("Harga bagasi = Rp." + bagasi1);
                System.out.println("Total harga = Rp. " + b);
            }
        } while (false);

    }

}
