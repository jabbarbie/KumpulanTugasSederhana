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
        int[] hargabali = new int[2];
        hargabali[0] = 350000;
        hargabali[1] = 550000;
        int[] hargamdn = new int[2];
        hargamdn[0] = 1500000;
        hargamdn[1] = 2000000;
        int[] hargaygy = new int[2];
        hargaygy[0] = 600000;
        hargaygy[1] = 800000;
        String user, pass, tgl, bln, thn;
        int pilihan, bagasi, bagasi1, pilihanjm, penumpang;
        int a = 0;
        int b = 0;

        String login;
        int loginlagi = 0;

        do {
            System.out.print("Masukan user    : ");
            user = br.readLine();
            System.out.print("Masukan Pasword : ");
            pass = br.readLine();
            if (user.equalsIgnoreCase("admin") && pass.equalsIgnoreCase("123")) {
                System.out.println(" Login anda Berhasil ");
            } else {
                System.out.println("Maaf username atau pasword anda salah");

                for (int i = 3; i > 0; i--) {
                    System.out.println("Coba " + i);
                    System.out.print("Masukan user    : ");
                    user = br.readLine();
                    System.out.print("Masukan Pasword : ");
                    pass = br.readLine();
                    if (user.equals("admin") && pass.equals("123")) {
                        break;
                        
                    }else if (i == 1){
                        System.out.println("Login Gagal");{
                        System.exit(0);
                }
                
                }
            }
            }
            
        } while (loginlagi==1);
        System.out.println("=================== Tanggal Keberangkatan ==================");
        System.out.print("Masukan Tanggal = ");
        tgl = br.readLine();
        System.out.print("Masukan Bulan = ");
        bln = br.readLine();
        System.out.print("Masukan Tahun = ");
        thn = br.readLine();
        do {
            System.out.println("");
            System.out.println("");
            System.out.println("======================= Tiket Pesawat =======================");
            System.out.println("");
            System.out.println(tgl + "-" + bln + "-" + thn);
            System.out.println(" Selamat Datang di Bandara Juanda Surabaya ");
            System.out.println(" 1. Bandara Juanda Surabaya --> Sukarno hatta (Jakarta)");
            System.out.println(" 2. Bandara Juanda Surabaya --> Husein Sastranegara (Bandung)");
            System.out.println(" 3. Bandara Juanda Surabaya --> Ngurah Rai (Bali)");
            System.out.println(" 4. Bandara Juanda Surabaya --> Kualanamu (Medan)");
            System.out.println(" 5. Bandara Juanda Surabaya --> Adisutjipto (Yogyakarta)");
            System.out.println(" 6. Exit");
            System.out.print("Masukan tujuan anda : ");
            pilihan = Integer.parseInt(br.readLine());
            switch (pilihan) {
                case 1:
                    System.out.println("======================= Tiket Pesawat =======================");
                    System.out.println("");
                    System.out.println("Pilihan anda : ");
                    System.out.println("Bandara Juanda Surabaya --> Sukarno hatta (Jakarta)");
                    System.out.println(tgl + "-" + bln + "-" + thn);
                    System.out.println("Harga Tiket :");
                    System.out.println("1. 07:00-09:00 = Rp.   700.000");
                    System.out.println("2. 16:00-18:00 = Rp. 1.000.000");
                    System.out.print("Pilih jadwal keberangkatan = ");
                    pilihanjm = Integer.parseInt(br.readLine());
                    System.out.print("Jumlah tiket yang ingin anda beli = ");
                    penumpang = Integer.parseInt(br.readLine());
                    if (pilihanjm == 1) {
                        a = hargajkt[0] * penumpang;
                    } else {
                        a = hargajkt[1] * penumpang;
                    }
                    for (int i = 0; i < penumpang; i++) {
                        System.out.println("");
                        System.out.print("Masukan Nama penumpang ke-" + (i + 1) + " : ");
                        String nama1 = br.readLine();
                        System.out.println("");
                    }
                    System.out.print("Masukan Berat bagasi anda (KG): ");
                    bagasi = Integer.parseInt(br.readLine());
                    bagasi1 = bagasi * 20000;
                    b = bagasi1 + a;
                    System.out.println("Harga bagasi = Rp." + bagasi1);
                    System.out.println("Harga Tiket anda : Rp."+a);
                    System.out.println("Total harga = Rp. " + b);
                    
                    break;

                case 2:
                    System.out.println("======================= Tiket Pesawat =======================");
                    System.out.println("");
                    System.out.println("Pilihan anda : ");
                    System.out.println("Bandara Juanda Surabaya --> Husein Sastranegara (Bandung)");
                    System.out.println(tgl + "-" + bln + "-" + thn);
                    System.out.println("Harga Tiket :");
                    System.out.println("1. 07:00-09:00 = Rp.   900.000");
                    System.out.println("2. 16:00-18:00 = Rp. 1.200.000");
                    System.out.print("Pilih jadwal keberangkatan = ");
                    pilihanjm = Integer.parseInt(br.readLine());
                    System.out.print("Jumlah tiket yang ingin anda beli = ");
                    penumpang = Integer.parseInt(br.readLine());
                    if (pilihanjm == 1) {
                        a = hargabdg[0] * penumpang;
                    } else {
                        a = hargabdg[1] * penumpang;
                    }
                    for (int i = 0; i < penumpang; i++) {
                        System.out.println("");
                        System.out.print("Masukan Nama penumpang ke-" + (i + 1) + " : ");
                        String nama1 = br.readLine();
                        System.out.println("");
                    }
                    System.out.print("Masukan Berat bagasi anda (KG): ");
                    bagasi = Integer.parseInt(br.readLine());
                    bagasi1 = bagasi * 20000;
                    b = bagasi1 + a;
                    System.out.println("Harga bagasi = Rp." + bagasi1);
                    System.out.println("Harga Tiket anda : Rp."+a);
                    System.out.println("Total harga = Rp. " + b);
                    break;

                case 3:
                    System.out.println("======================= Tiket Pesawat =======================");
                    System.out.println("");
                    System.out.println("Pilihan anda : ");
                    System.out.println("Bandara Juanda Surabaya --> Ngurah Rai (Denpasar)");
                    System.out.println(tgl + "-" + bln + "-" + thn);
                    System.out.println("Harga Tiket :");
                    System.out.println("1. 07:00-09:00 = Rp. 350.000");
                    System.out.println("2. 16:00-18:00 = Rp. 550.000");
                    System.out.print("Pilih jadwal keberangkatan = ");
                    pilihanjm = Integer.parseInt(br.readLine());
                    System.out.print("Jumlah tiket yang ingin anda beli = ");
                    penumpang = Integer.parseInt(br.readLine());
                    if (pilihanjm == 1) {
                        a = hargabali[0] * penumpang;
                    } else {
                        a = hargabali[1] * penumpang;
                    }
                    for (int i = 0; i < penumpang; i++) {
                        System.out.println("");
                        System.out.print("Masukan Nama penumpang ke-" + (i + 1) + " : ");
                        String nama1 = br.readLine();
                        System.out.println("");
                    }
                    System.out.print("Masukan Berat bagasi anda (KG): ");
                    bagasi = Integer.parseInt(br.readLine());
                    bagasi1 = bagasi * 20000;
                    b = bagasi1 + a;
                    System.out.println("Harga bagasi = Rp." + bagasi1);
                    System.out.println("Harga Tiket anda : Rp."+a);
                    System.out.println("Total harga = Rp. " + b);
                    break;

                case 4:
                    System.out.println("======================= Tiket Pesawat =======================");
                    System.out.println("");
                    System.out.println("Pilihan anda : ");
                    System.out.println("Bandara Juanda Surabaya --> Kualanamu (Medan)");
                    System.out.println(tgl + "-" + bln + "-" + thn);
                    System.out.println("Harga Tiket :");
                    System.out.println("1. 07:00-09:00 = Rp. 1.500.000");
                    System.out.println("2. 16:00-18:00 = Rp. 2.000.000");
                    System.out.print("Pilih jadwal keberangkatan = ");
                    pilihanjm = Integer.parseInt(br.readLine());
                    System.out.print("Jumlah tiket yang ingin anda beli = ");
                    penumpang = Integer.parseInt(br.readLine());
                    if (pilihanjm == 1) {
                        a = hargamdn[0] * penumpang;
                    } else {
                        a = hargamdn[1] * penumpang;
                    }
                    for (int i = 0; i < penumpang; i++) {
                        System.out.println("");
                        System.out.print("Masukan Nama penumpang ke-" + (i + 1) + " : ");
                        String nama1 = br.readLine();
                        System.out.println("");
                    }
                    System.out.print("Masukan Berat bagasi anda (KG): ");
                    bagasi = Integer.parseInt(br.readLine());
                    bagasi1 = bagasi * 20000;
                    b = bagasi1 + a;
                    System.out.println("Harga bagasi = Rp." + bagasi1);
                    System.out.println("Harga Tiket anda : Rp."+a);
                    System.out.println("Total harga = Rp. " + b);
                    break;

                case 5:
                    System.out.println("======================= Tiket Pesawat =======================");
                    System.out.println("");
                    System.out.println("Pilihan anda : ");
                    System.out.println("Bandara Juanda Surabaya --> Adisutjipto (Yogyakarta)");
                    System.out.println(tgl + "-" + bln + "-" + thn);
                    System.out.println("Harga Tiket :");
                    System.out.println("1. 07:00-09:00 = Rp. 600.000");
                    System.out.println("2. 16:00-18:00 = Rp. 800.000");
                    System.out.print("Pilih jadwal keberangkatan = ");
                    pilihanjm = Integer.parseInt(br.readLine());
                    System.out.print("Jumlah tiket yang ingin anda beli = ");
                    penumpang = Integer.parseInt(br.readLine());
                    if (pilihanjm == 1) {
                        a = hargaygy[0] * penumpang;
                    } else {
                        a = hargaygy[1] * penumpang;
                    }
                    for (int i = 0; i < penumpang; i++) {
                        System.out.println("");
                        System.out.print("Masukan Nama penumpang ke-" + (i + 1) + " : ");
                        String nama1 = br.readLine();
                        System.out.println("");
                    }
                    System.out.print("Masukan Berat bagasi anda (KG): ");
                    bagasi = Integer.parseInt(br.readLine());
                    bagasi1 = bagasi * 20000;
                    b = bagasi1 + a;
                    System.out.println("Harga bagasi = Rp." + bagasi1);
                    System.out.println("Harga Tiket anda : Rp."+a);
                    System.out.println("Total harga = Rp. " + b);
                    break;
                case 6:
                    System.exit(0);
            }
        } while (false);

    }
}