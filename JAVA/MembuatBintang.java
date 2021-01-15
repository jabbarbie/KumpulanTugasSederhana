import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;


public class bintang{
	public static void main(String args[]) throws IOException {		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int kotak, tengah, akg;

		System.out.print("Inputkan Jumlah Kotak : ");
		kotak = Integer.parseInt(br.readLine());
		tengah = kotak / 2 + 1;
		akg = kotak;
		 for (int i = 1; i <= akg; i++) {
                        for (int j = 1; j <= akg; j++) {
                            if ((i<=j && i+j<=akg+1)  ||  (i>akg/2 && i>=j && i+j>=akg+1)) {
                                System.out.print("*");
                            } else {
                                System.out.print(" ");
                            }
                        }System.out.println("");
                    }

		for(int i = 1; i <= kotak; i++){
			//wajik = i * 3;
			for(int j = 1; j <= kotak; j++){
				if(i == tengah){
					System.out.print(i + " ");
				}else{
					if(j == tengah){
						System.out.print(j + " ");
					}else if((j >= (tengah - (i - 1)) && j <= (tengah + (i - 1)) ) || i > j){
						System.out.print(j + " ");				
					}
					else{
						System.out.print("  ");
					}	
				}
				
			}	
			System.out.println("");
						
		}
		System.out.println('\r');
		/*
j >= (tengah - (i - 1)) && j <= (tengah + (i - 1))
0 => 5
1 => 456 (1/5)
2 => 34567
3 => 2345678		
4 => 123456789
5 => 2345678
6 => 34567
		for(int i = 1; i <= kotak; i++){
			for(int j = 1; j <= kotak; j++){
				if(i == tengah){
					System.out.print("* ");
				}else{
					if(j == tengah){
						System.out.print("* ");
					}else{
						System.out.print("  ");
					}	
				}
				
			}	
			System.out.println("");
						
		}

		System.out.println('\r');
		for(int i = 1; i <= kotak; i++){
			for(int j = 1; j <= kotak; j++){
				if (i == 1 || i == kotak || i == tengah){					
					System.out.print("* ");
				}else{
					if(j == 1 || j == kotak || j == tengah){
						System.out.print("* ");	
					}else{
						System.out.print("  ");	
					}					
				}
			}	
			System.out.println("");
						
		}
		System.out.println('\r');

		for(int i = 1; i <= kotak; i++){
			for(int j = 1; j <= kotak; j++){
				if (i == 1 || i == kotak){					
					System.out.print("* ");
				}else{
					if(j == 1 || j == kotak){
						System.out.print("* ");	
					}else{
						System.out.print("  ");	
					}					
				}
			}	
			System.out.println("");
						
		}
*/	
}
	
	
}
