import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

class Hello{
	public static void main(String args[]) throws IOException {

		String barang;
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("Masukkan Sempak ");
		barang = br.readLine();
		System.out.println("Barang anda adalah : " + barang );
	}
}