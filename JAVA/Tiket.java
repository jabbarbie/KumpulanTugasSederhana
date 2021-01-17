import java.util.*;
class Tiket {
	String[][] data = new String[10][5]; // maksimal tiket yg bisa diinput 10
	static String[]	kota = {"Surabaya", 
							"Bandung", 
							"Palangka Raya",
							"Bali"};
	static String[] daftar_waktu = {"Pagi", "Siang", "Sore","Malam"};
	String namaku ;

	static String garis(){
		return "=====================================";
	}
static private void login(){
		byte ulang = 1; 
		byte max_login = 3;

		String username, passwd;
		Scanner br = new Scanner(System.in);
		System.out.println("\n=============== LOGIN ===============");

		do{
			System.out.print("Masukkan Username : ");
			username = br.nextLine();
			System.out.print("Masukkan Password : ");
			passwd = br.nextLine();

			if(username.equals("admin") && passwd.equals("admin")){
				menu();
				return;
			}
			
			System.out.println("Login Gagal! Kesempatan tersisa " + (max_login - ulang) + "x");
			ulang++;
		}while(ulang <= max_login);

		System.out.print("Anda sudah melewati batas login sebanyak 3x");
		System.exit(0);
	}

	static void menu(){
		int pilih = 0;
		System.out.println(garis());
		System.out.println("=========== VHILHEST AIR ============");
		System.out.println(garis());
		
		System.out.println("1. Pesan Tiket ");
		System.out.println("2. Cetak ");
		System.out.println("3. Help");
		System.out.println("4. Exit");

		System.out.println(garis());
		System.out.print("Pilih Menu : ");

		// try{
			Scanner br = new Scanner(System.in);

			Tiket pesan = new Tiket();
			pilih = br.nextInt();
			switch(pilih){
				case 1:
					pesan.inputTiket();
					menu();
					break;
				case 2:
					pesan.cetakTiket();
					menu();
					break;
				case 3:
					bantuan();
					menu();
					break;
				case 4:
				System.exit(0);
					break;
				default:
					System.out.println("Pilihan anda salah !");
					menu();
					break;
			}

		// }catch(Exception e){
		// 	System.out.println("Hanya Input Angka !");
		// 	menu();
		// }
	}
	public static void main(String[] args){
			// Tiket pesan = new Tiket();
			// pesan.inputTiket();
			// login();
			menu();
	}
	static void bantuan(){}; 

	public void inputTiket(){
		char lagi;
		byte i = 0;
		String nama;
		int asal, tujuan, waktu, harga;

		
		Scanner br = new Scanner(System.in);
		Tiket Pemesanan = new Tiket();
		do{
			// Nama
			System.out.println(garis());
			System.out.print("Nama Pemesan : ");
			nama 	= br.next();
			// Kota Asal
			tampilkanKota(-1);
			System.out.print("Pilih Kota Asal : ");
			asal 	= br.nextInt() - 1;
			// Kota Tujuan
			tampilkanKota(asal);
			System.out.print("Pilih Kota Tujuan : ");
			tujuan = br.nextInt() - 1;
			// Waktu (Pagi - Malam)
			System.out.println(garis());
			for(byte w = 0; w < daftar_waktu.length; w++)
				System.out.println((w+1) + ". " + daftar_waktu[w]);

			System.out.println(garis());
			System.out.print("Pilih Waktu Penerbangan : ");
			waktu 	= br.nextInt();

			// Harga
			harga = harga_tiket();
			System.out.println("Proses Simpan ke Array");
			// simpan data tadi ke array
			this.data[i][0]	= nama;
			this.data[i][1]	= Integer.toString(asal);
			this.data[i][2]	= Integer.toString(tujuan);
			this.data[i][3]	= Integer.toString(waktu);
			this.data[i][4]	= Integer.toString(harga);

			System.out.println("Data Pemesanan ke " + i + " Kolom 0 " + this.data[i][0]);
			// cetakTiket();
			System.out.print("Input data pemesan lagi ? Pilih Y/T  ");
			this.namaku = nama;

			i++;

		}while(br.next().equalsIgnoreCase("Y"));
	}; 

	// fungsi kecil 
	static void tampilkanKota(int pilih_kota){
		System.out.println("=====================================");
		for(byte i = 0; i < kota.length; i++){
			if(i != pilih_kota)
				System.out.println((i+1) + ". " + kota[i]);
		}
		System.out.println("=====================================");
	}
	String getNama(){
		return this.namaku;
	}
	void cetakTiket(){
		// System.out.println("Data nya " + this.data[0][0]);
		
		/*
		for(byte i = 0; i < this.data.length; i++){
			for(int j = 0; j < 5; j ++){
				System.out.println(i + " Isi Data " + this.data[i][j]);
			}
		}
		*/
		System.out.println("namaku adalah " + getNama());
	}
	static int harga_tiket(){
		return 500000;
	}
}