from os.path import *

# mengambil nama folder, tanpa full path
namadir = 'D://YouTube'
print(basename(namadir)) # output = YouTube


# mengambil nama folder, full path 
namafile = "D://YouTube/TaylorSwiftVEVO/Taylor Swift  Love Story Live on Letterman.mp4"
print(dirname(namafile)) # output = D://YouTube/TaylorSwiftVEVO

# mendeteksi penggunaan backslash atau \ 
print(isabs(namafile))

# mengecek apakah path berupa directory atau bukan
print(isdir(namafile)) # false, karena namafile tertuju pada file bukan folder

# mengecek apakah path berupa file atau bukan
print(isfile(namafile)) # true, karena namafile adalah file

# mengubah text ke lower (huruf kecil)
# mengubah backslash ke normal slash / ke \
print(normcase(namafile)) # output = d://youtube.....

# mengubah backslash ke normal slash / ke \ dan // ke \
print(normpath(namafile))


# mengambil, kapan terakhir file tersebut diakses
print(getatime(namafile)) # output = unix mktime 1610855579
# mengambil, kapan terakhir file tersebut diedit
print(getmtime(namafile)) # output = unix mktime 1610855579

# mengambil size dari sebuah file - format bytes
print(getsize(namafile)) 


# menggabungkan kata menjadi format path 
namafile = join('D:/','YouTube','Nabila Razali Entertainment',
                        'NABILA RAZALI feat MK KClique  PELUANG KEDUA OFFICIAL MUSIC VIDEO.mp4')
print(namafile) # output = D\YouTube\Nabila Razali Entertainment\NABILA RAZALI feat MK KClique  PELUANG KEDUA OFFICIAL MUSIC VIDEO.mp4

# merecovery file path ke format yg sebenarnya
# print(realpath(namafile))

# print(samefile(namafile, namafile))
namafile = expanduser(namafile)
print(namafile)
print(isfile(namafile))


# SETELAH DI TELUSURI
# Penggunaaan path.join, drive letternya tidak otomatis terbuat
# Jadi formatnya akan tetap D:Namafolder, tidak bisa D:/Namafolder
# Untuk itu, ada library baru di python 3.4
