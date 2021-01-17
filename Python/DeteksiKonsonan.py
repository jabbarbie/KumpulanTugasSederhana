kata = input("Masukkan kata :")
for x in kata:
	if(x in ['a','i','u','e','o']):
		huruf = "Vokal"
	else:
		huruf = "Konsonan"
	
	if not x == ' ':
		print(f"{x} adalah {huruf}")

