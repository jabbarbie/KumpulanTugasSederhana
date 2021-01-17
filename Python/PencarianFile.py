import os

pathnow = __file__
pathnowrealpath = os.path.realpath(pathnow)
tanpanamafile = os.path.dirname(pathnowrealpath)
# print(pathnow)



# endswith - mengambil string terakhir 
# return : boolean
contohfile = "satekambingmp3"
print(contohfile.endswith('gmp3')) # True

# Menampilkan semua berdasarkan ektension
# os.walk - menjelajah semua isi dalam directory, lebih efisien daripada perulangan manual

oswalk = os.walk(tanpanamafile)
for rootnya, semuadir, semuafile in oswalk:
    for filenya in semuafile:
        # print(filenya)
        if filenya.endswith('py'):
            print(filenya)