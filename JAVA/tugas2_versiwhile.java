import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

class Tugas{
	public static void main(String args[]) throws IOException {		
		int pilih,berat = 0;
		String no_bebek = "",
			   nama 	= "", 
			   pemilik 	= "", 
			   alamat 	= "",
			   jenis 	= "";

		boolean lulus = false;
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

		pilih = 1;
		do{
			System.out.println("\r");
			System.out.println("1. Input Data Anggota Koperasi Bebek");
			System.out.println("2. Pengumuman Hasil Seleksi");
			System.out.println("3. Keluar / Exit");
			System.out.println("\r");
			
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
					berat 	= Integer.parseInt(br.readLine()); 
					System.out.print("Masukkan Jenis Makanan Bebek :");
					jenis 	= br.readLine();
					break;

				case 2:
					System.out.println("No Anggota Bebek : " + no_bebek);
					System.out.println("Nama Bebek : " + nama);
					System.out.println("Berat Badan Bebek : " + berat + " kg");
					System.out.println("Jenis Makanan Bebek : " + jenis);
					//jenis = "jenis ikan adalah-" + jenis + "-";
					
					// System.out.println("-" + jenis + "");
					if(berat <= 10 && jenis.equals("ikan tuna"))
						lulus = true;
					else if((berat >= 11 && berat <= 20) && jenis.equals("bubur ayam"))
						lulus = true;
					else if((berat >= 21 && berat <= 30) && jenis.equals("nasi uduk"))
						lulus = true;
					else
						lulus = false;

					System.out.println("\r");
					if(lulus == true){
						System.out.println("Dinyatakan Lulus Seleksi dan dapat menjadi Anggota Koperasi " );	
					}else
					
					break;			
			}
		}while(pilih < 3);

		
	}
}