from pathlib import *
import sys

# Cek apakah program dijalankan di windows atau tidak
if sys.platform == 'win32':
    print("======== WINDOWS =========")

    lokasi = PureWindowsPath('D:/','YouTube')
    # Memecah lokasi path menjadi beberapa bagian 
    print(lokasi.parts) # Output = ['D:', 'YouTube']
    # Mengambil drive dari sebuah path
    print(lokasi.drive) # Output = D:
    # Sama seperti drive, tetapi yg ini ada backticknya
    print(lokasi.anchor) # Output = D:\

    lokasi = PureWindowsPath(lokasi, 'Anissa Aziza')
    lokasifile = PureWindowsPath(lokasi, 'FULL ALEA NGOCEH.mp4')
    print(lokasifile) # Output = D:\YouTube\Anissa Aziza\FULL ALEA NGOCEH.mp4
    print(lokasifile.parent) # Output = D:\YouTube\Anissa Aziza
    print(lokasifile.name) # Output = FULL ALEA NGOCEH.mp4

    # Extension
    lokasifile = PureWindowsPath(lokasi, 'Ale-Ale.min.mp4')
    print(lokasifile) # D:\YouTube\Anissa Aziza\Ale-Ale.min.mp4
    print(lokasifile.suffix) #.mp4
    print(lokasifile.suffixes) # ['.min','.mp4']
    print(lokasifile.stem) # Ale-Ale.min (Nama file tanpa ekstension akhir)

    # Conver ke URL 
    print(lokasifile.as_uri()) # file:///D:/YouTube/Anissa%20Aziza/Ale-Ale.min.mp4 - raise ValueError

    # Cek apakah ini benar format url atau bukan
    print(lokasifile.is_absolute()) # True
    lokasifile = PureWindowsPath(lokasi.drive, 'b')
    print(lokasifile.is_absolute()) # False karena D:b bukan format path

    # JOIN
    lokasifile = PureWindowsPath(lokasi.drive, '/')
    lokasifile = lokasifile.joinpath('Dokument','Anime_Review','kerangka.css')
    print(lokasifile) # D:\Dokument\Anime_Review\kerangka.css

    # FileName
    print(lokasifile) # D:\Dokument\Anime_Review\kerangka.css
    print(lokasifile.with_name('sate.mp4')) # D:\Dokument\Anime_Review\sate.mp4
    print(lokasifile.with_stem('oke.mp4')) # D:\Dokument\Anime_Review\oke.mp4.css
    print(lokasifile.with_suffix('.mp3')) # D:\Dokument\Anime_Review\kerangka.mp3

    # OS.PATH
    import os
    print(WindowsPath("D:/YouTube/A"))
    print(os.name) # output = nt
    print(Path.home()) # C:\Users\kroto
    print(Path.is_block_device())





