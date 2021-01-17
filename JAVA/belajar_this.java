import java.util.Scanner;

class belajar_this{
    public String nama;

    public void setName(){
        this.nama = "fauzi";
    }
    String cetakNama(){
        return this.nama;
    } 
    public static void main(String[] args){
        belajar_this Anu = new belajar_this();
        Anu.setName();
        System.out.println("namanya " + Anu.cetakNama());
    }
}