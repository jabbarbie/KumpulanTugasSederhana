import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

class Tugas{
	public static void main(String args[]) throws IOException {		
		int pilih;
		String no_bebek = "",
			   nama 	= "", 
			   pemilik 	= "", 
			   alamat 	= "",
			   berat 	= "", 
			   jenis 	= "";
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

		System.out.println("1. Input Data Anggota Koperasi Bebek");
		System.out.println("2. Pengumuman Hasil Seleksi");
		System.out.println("3. Keluar / Exit");
		System.out.print("Pilih Menu : ");
		pilih = Integer.parseInt(br.readLine());
		switch(pilih){
			case 1:
				System.out.print("Masukkan No Anggota Bebek :");
				no_bebek = br.readLine();
				System.out.print("Masukkan Nama Bebek :");
				nama 	= br.readLine();
				System.out.print("Masukkan Nama Pemilik Bebek :");
				pemilik = br.readLine();
				System.out.print("Masukkan Alamat Bebek :");
				alamat 	= br.readLine();
				System.out.print("Masukkan Berat Badan Bebek :");
				berat 	= br.readLine(); 
				System.out.print("Masukkan Jenis Makanan Bebek :");
				jenis 	= br.readLine();
				break;

			case 2:
				System.out.println("No Anggota Bebek : " + no_bebek);
				System.out.println("Nama Bebek : " + nama);
				System.out.println("Berat Badan Bebek : " + berat);
				System.out.println("Jenis Makanan Bebek : " + jenis);
				System.out.println("Dinyatakan Lulus Seleksi dan dapan menjadi Anggota Koperasi " );

				break;			
		}

		
	}
}