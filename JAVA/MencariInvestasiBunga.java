import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

class Bebeks {
	public static void main(String args[]) throws IOException {		
		int invest = 1000,
			jumlah_tahun;
		
		double j = 0,
			   total_bunga = 0;

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

		System.out.print("Jumlah Investasi : ");
		invest = Integer.parseInt(br.readLine());
		System.out.print("Berapa tahun ? ");
		jumlah_tahun = Integer.parseInt(br.readLine());

		System.out.println("Saldo Awal : " + invest);
		System.out.println("\r");
		for(int i = 1; i <= jumlah_tahun; i++){
			 // bunga +=
			 j = invest + (invest * (0.05 * i));
			System.out.println("Tahun ke-" + i + " = " + j);
		}
	}
}

