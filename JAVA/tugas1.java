import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

class Tugas{
	public static void main(String args[]) throws IOException {		
		try{
			String nama_depan, nama_belakang, alamat, tempat_lahir, tanggal_lahir;
			int usia;

			// nama toko
			String toko_nama = "            Toko Buku \"Cahaya Ilmu Sejati\" ",
				   toko_alamat = "            Jl. Kebon Jahe no.23, Sidoarjo",
				   garis = "       =====================================";

			BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

			// input 
			System.out.println("\r");		
			System.out.println(garis);
			System.out.println("                 Input Data Pelanggan");
			System.out.println(toko_nama);
			System.out.println(toko_alamat);
			System.out.println(garis);
			System.out.println("\r");		

			System.out.print("Masukkan Nama Depan : ");
			nama_depan = br.readLine();
			System.out.print("Masukkan Nama Belakang : ");
			nama_belakang = br.readLine();
			System.out.print("Masukkan Alamat : ");
			alamat = br.readLine();
			System.out.print("Masukkan Tempat Lahir : ");
			tempat_lahir = br.readLine();
			System.out.print("Masukkan Tanggal Lahir  : ");
			tanggal_lahir = br.readLine();
			System.out.print("Masukkan Usia Pelanggan : ");
			usia = Integer.parseInt(br.readLine());

			// output
			System.out.println("\r");		
			System.out.println(garis);
			System.out.println("                  Data Pelanggan");
			System.out.println(toko_nama);
			System.out.println(toko_alamat);
			System.out.println(garis);
			System.out.println("\r");

			System.out.println("Nama Lengkap: " + nama_depan + " " + nama_belakang);
			System.out.println("Alamat : " + alamat);
			System.out.println("Tempat Lahir : " + tempat_lahir);
			System.out.println("Tanggal Lahir  : " + tanggal_lahir);
			System.out.println("Usia Pelanggan : " + usia);
		}catch (Exception e){

			System.out.println("Usia harus berupa angka");

		}

	}
}