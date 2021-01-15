import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Javpro1 {
    public static void main(String[] args)throws IOException {
        //Syntax Input
        BufferedReader sate = new BufferedReader(new InputStreamReader(System.in));
        
        try {
             //Untuk Input Biodata
        System.out.print("Input NIM : ");
        String nim = sate.readLine();
        
		System.out.print("Input Nama : ");
        String nama = sate.readLine();
        
		System.out.print("Input Umur : ");
        int umur = Integer.parseInt(sate.readLine());
        
        System.out.println("NIM : " + nim);
        System.out.println("Nama : " + nama);
        System.out.println("Umur : " + umur);
        
		} catch (Exception e) {
            System.out.println("Input Harus Angka !!");
        }
        
    }
    
}
