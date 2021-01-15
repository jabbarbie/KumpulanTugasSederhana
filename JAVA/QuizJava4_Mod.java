import java.io.*;

public class QuizJava4 {
  public static void main(String[] args)throws IOException {
    BufferedReader br = new BufferedReader (new InputStreamReader(System.in));
    
    System.out.print("Masukkan Baris :");
    int baris = Integer.parseInt(br.readLine());
    System.out.print("Masukkan Kolom :");
    int kolom = Integer.parseInt(br.readLine());
    
  	int terbesar = 0;
  	int terkecil = 0;
  	int keseluruhan = 0;
  	int jumlah_perbaris = 0;

  	int[] jumlah_baris = new int[5];
  	int[][] data = new int[100][100];

    for(int i=1; i <= baris; i++){
    	// reset ke 0
    	jumlah_perbaris = 0;
    	for(int j=1; j <= kolom; j++){
    		System.out.print("Masukkan Data Baris " + i + " Kolom " + j + " : ");    	
    		data[i][j]	= Integer.parseInt(br.readLine());	

    		keseluruhan += data[i][j];

			// 10 > 5 ? True
			// 10 > 11 ? False
			// 10 < 5 ? False    	
			// terkecil = 1 ; 10 < terkecil ? false
			// terkecil = 11 ; 10 < terkecil ? true

    		if(i == 1 & j == 1){
    			// set default nilai terkecil ke inputan awal
    			terkecil = data[i][j];
    		}

    		if(data[i][j] >= terbesar){
    			terbesar = data[i][j];
    		}else if(data[i][j] < terkecil){
    			terkecil = data[i][j];
    		}
    		// System.out.print("Terbesar Saat Ini" + terbesar );    	
    		// System.out.println(" Terkecil Saat Ini" + terkecil );    	
    		jumlah_perbaris = jumlah_perbaris + data[i][j];

    	}
    	jumlah_baris[i]	= jumlah_perbaris;
    	// System.out.println("Jumlah Baris " + i + " adalah " + jumlah_baris[i] );    	

    }
	
    // tampilkan baris dan kolom
    
    
    for(int i=1; i <= baris; i++){
    	for(int j=1; j <= kolom; j++){
	       System.out.print(data[i][j] + "\t");
    	}
	    System.out.println();
    }
    
    
      System.out.println("Total Jumlah Keseluruhan adalah " + keseluruhan);
      for(int i = 1; i <= baris; i++){
	      System.out.println("Total Jumlah Baris ke-" + i + " adalah " + jumlah_baris[i]);
      }      
      System.out.println("Nilai Terbesar : "+terbesar);
      System.out.println("Nilai Terkecil : "+terkecil);

	

  }
}
