import java.io.*;
import java.util.Date;
import java.text.SimpleDateFormat;
// import java.time.LocalDate;
class Tiket_Static{
    private static String[][] data_pemesan = new String[10][6];
	private static String[] daftar_waktu = {"Pagi","Siang","Sore","Malam"};
	private static String[]	kota = {"Surabaya", 
							"Bandung", 
							"Palangka Raya",
							"Bali"};

    static String garis(String kata){
        String bentuk_garis = "======================================";
        if(kata.equals(""))
            return bentuk_garis;
        else{
            int jumlah_garis = bentuk_garis.length();
            int jumlah_kata  = kata.length();
            int dibagi = ((jumlah_garis - jumlah_kata) - 2) / 2; // 2 untuk spasi

            String garis_jadi = "";
            for(byte i = 1; i < (jumlah_garis - jumlah_kata); i++){
                if(i == dibagi){
                    garis_jadi += " " + kata + " ";
                    continue;
                }
                garis_jadi += "=";

            }
            return garis_jadi;
           
        }
    }
    private static void menu()throws IOException{
        int pilih = 0;
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        System.out.println(garis(""));
		System.out.println(garis("VHILHEST AIR"));
		System.out.println(garis(""));
		
		System.out.println("1. Pesan Tiket ");
		System.out.println("2. Cetak ");
		System.out.println("3. Help");
		System.out.println("4. Exit");

		System.out.println(garis(""));
		System.out.print("Pilih Menu : ");
		try{
			pilih = Integer.parseInt(br.readLine());
			switch(pilih){
				case 1:
					pesanTiket();
					menu();
					break;
				case 2:
					cetakTiket();
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
        } catch(Exception e){
            System.out.println("Inputan hanya boleh angka !");
            menu();
        }
    }
    static private void login()throws IOException{
		byte ulang = 1; 
		byte max_login = 3;

		String username = "admin"
			  ,passwd	= "admin";
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in)); 
        System.out.println(garis("Login"));

		do{
			System.out.print("Masukkan Username : ");
			String input_username = br.readLine();
			System.out.print("Masukkan Password : ");
			String input_passwd = br.readLine();

			if(input_username.equals(username) && input_passwd.equals(passwd)){
				menu();
				return;
			}
			
			System.out.println("Login Gagal! Kesempatan tersisa " + (max_login - ulang) + "x");
			ulang++;
		}while(ulang <= max_login);

		System.out.print("Anda sudah melewati batas login sebanyak 3x");
		System.exit(0);
    } 
    
    static private void pesanTiket()throws IOException{
		byte i = 0;
		String nama,tanggal,
			   lagi;
		int asal, tujuan, waktu, harga;

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		do{
			System.out.println(garis(""));
			// System.out.println("Pemesan Ke - " + (i+1));
			// System.out.println(garis("") + "\n");

			System.out.print("Nama Pemesan : ");
			nama 	= br.readLine();
            
            tampilkanKota(-1);
			System.out.print("Pilih Kota Asal : ");
			asal 	= Integer.parseInt(br.readLine()) - 1;
            
            tampilkanKota(asal);
			System.out.print("Pilih Kota Tujuan : ");
			tujuan = Integer.parseInt(br.readLine()) - 1;
            
            // Waktu Pemesanan
            System.out.println(garis(""));
			for(byte w = 0; w < daftar_waktu.length; w++)
				System.out.println((w+1) + ". " + daftar_waktu[w]);

			System.out.println(garis(""));
			System.out.print("Pilih Waktu Penerbangan : ");
			waktu 	= Integer.parseInt(br.readLine()) - 1;

			System.out.println(garis(""));
			System.out.println("Format : Tanggal/Bulan/Tahun");
			System.out.println("Contoh : 17/04/2019");
			System.out.print("Tanggal Keberangkatan : ");
			tanggal = br.readLine();
			// Harga

			// simpan data_pemesan tadi ke array
			data_pemesan[i][0]	= nama;
			data_pemesan[i][1]	= Integer.toString(asal);
			data_pemesan[i][2]	= Integer.toString(tujuan);
			data_pemesan[i][3]	= Integer.toString(waktu);
			data_pemesan[i][5]	= tanggal;

			harga = harga_tiket(i);
			data_pemesan[i][4]	= Integer.toString(harga);

			System.out.print("Input data pemesan lagi ? Pilih Y/T  ");
			lagi = br.readLine();
			i++;

			System.out.println(garis(""));
		}while(lagi.equalsIgnoreCase("Y"));
    }
    static private void cetakTiket(){
		if(data_pemesan[0][0] == null){
			System.out.println("Belum ada pemesanan tiket ");
			return;
		}
		System.out.println(garis(""));
		System.out.println("Cetak Data - Pemesanan Tiket");
		
		for(int i = 0; i < data_pemesan.length; i++){
			if(data_pemesan[i][0] == null){
				continue;
			}
			System.out.println(garis(""));
			System.out.println("Pemesan Ke - " + (i+1));
			System.out.println(garis(""));

			System.out.println("Nama 	: " + data_pemesan[i][0]);
			System.out.println("Asal 	: " + getKota(data_pemesan[i][1]));
			System.out.println("Tujuan 	: " + getKota(data_pemesan[i][2]));
			System.out.println("Waktu  	: " + getWaktu(data_pemesan[i][3]));
			System.out.println("Harga 	: " + data_pemesan[i][4]);

		}
    }
    static private void bantuan(){
		System.out.println(garis(""));
		System.out.println(garis("Bantuan"));
		System.out.println(garis(""));

		System.out.println("Berikut adalah langkah - langkah pemesanan tiket : ");
		System.out.println("1. Pilih menu pesan tiket (ketik angka 1) ");
		System.out.println("2. Masukkan data yang diperlukan (nama.. tanggal.. etc)");
		System.out.println("3. Ketik Y untuk tetap lanjut menginputkan data pemesan ");
		System.out.println("4. Pilih menu cetak (ketik angka 2) untuk mencetak data pemesan");
		System.out.println("5. Jika sudah, pilih menu exit untuk menutup program ");
    }
    public static void main(String[] args)throws IOException{
        login();
		menu();
    }


	// fungsi - fungsi 
	static void tampilkanKota(int pilih_kota){
		System.out.println("=====================================");
		for(byte i = 0; i < kota.length; i++){
			if(i != pilih_kota)
				System.out.println((i+1) + ". " + kota[i]);
		}
		System.out.println("=====================================");
	}

	static int harga_tiket(int i){
		int harga_default 	= 500000,
			harga 			= 0,
			selisih_hari	= selisihTanggal(data_pemesan[i][5]);
			// waktu			= Integer.parseInt(data_pemesan[i][3]), 

		if(selisih_hari == 0) // dipesan saat itu juga 
			harga = harga_default * (100 / 30);
		else if(selisih_hari == 1)
			harga = harga_default * (100 / 15);
		else
			harga = harga_default;
		
		return harga;
	}
	static String getKota(String params_kota){
		/* params_kota masih dalam bentuk string, 
		   karna index array harus berupa int
		   maka dari itu harus diconvert dahulu ke dalam int
		*/
		int id_kota = Integer.parseInt(params_kota);
		return kota[id_kota];
	}
	static String getWaktu(String params_waktu){
		String[] daftar_waktu = {"Pagi","Siang","Sore","Malam"};
		/* params_waktu masih dalam bentuk string, 
		   karna index array harus berupa int
		   maka dari itu harus diconvert dahulu ke dalam int
		*/
		int id_waktu = Integer.parseInt(params_waktu);
		return daftar_waktu[id_waktu];
	}

	static int selisihTanggal(String inputan_tanggal){
		try {	
			
			String 	tanggal = inputan_tanggal;

			/* 	mengubah tanggal yg diinputkan oleh user (yg bertipe string)
				menjadi tipe_data date.. dengan memanfaatkan package simpledateformat
			*/ 
			Date tanggal_pesan = new SimpleDateFormat("dd/MM/yyyy").parse(tanggal);
			//	mengambil tanggal sekarang 
			Date tanggal_sekarang = new Date();

			/* 	getTime = berfungsi untuk mengubah tanggal menjadi milisecond
				kemudian dari tanggal_pemesanan dikurangi tanggal_sekarang

			*/
			long diff = tanggal_pesan.getTime() - tanggal_sekarang.getTime();
			long hari = diff / (24 * 60 * 60 * 1000);
			return (int) hari;
		} catch (Exception e) {
			return 0;
		}
	}
}
