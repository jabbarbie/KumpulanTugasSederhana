import java.io.*;

class Buku {
	private String Pengarang;
	private String Judul;

	public static void setPengarang(String Pengarang){
		this.Pengarang = Pengarang;
	}

	public static void setJudulPengarang(String Judul){
		this.Judul = Judul;
	}

	public static String getPengarang(){
		return Pengarang;
	}

	public static String getJudul(){
		return Judul;
	}
}

public class DemoBuku{
	public static void main(String[] args)throws IOException{

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.println("Masukkan Pengarang : ");
		String NMPengarang=br.readLine();
		System.out.println("Masukkan Judul : ");
		String NMBuku=br.readLine();

		Buku bk=new Buku();
		bk.setPengarang(NMPengarang);
		bk.setJudulPengarang(NMBuku);
		System.out.println("Nama Pengarang : "+bk.setPengarang());
		System.out.println("Nama Judul Buku : "+bk.setJudulPengarang());
	}
}
	

