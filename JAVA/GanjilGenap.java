import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;


public class bintang{
	public static void main(String args[]) throws IOException {		
		int bilangan;
		String genap, 
				prima = "Bukan ";

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("Input bilangan : ");
		bilangan = Integer.parseInt(br.readLine());

		// Ganjil Genap
		if(bilangan % 2 == 0){
			genap = "Genap ";
		}else{
			genap = "Ganjil ";
		}

		// Prima
		if(bilangan == 1){
			prima = "";
		}else if(bilangan == 2 || bilangan == 3){
			prima = "";
		}else if((bilangan % 2 != 0) && (bilangan % 3 != 0)){
			prima = "";
		}
		
		System.out.println(prima + "Bilangan Prima dan Bilangan " + genap);
		
	}
	
}
