import psutil

# Mengambil memory yang tersedia, total, bebas, digunakan
def getMemory():
    mem = psutil.virtual_memory()
    for i in range(20):
        print(mem)

# Mengambil Semua Harddisk - Partisi
def getHDD():
    dis = psutil.disk_partitions()
    for i in dis:
        print(i)

# Mengambil Informasi disk C
def getDisk():
    C = psutil.disk_usage('C:/')
    print(C)

def ulang(data):
    for i in data:
        print(i)
# Network
# ulang(psutil.net_io_counters(pernic=True))
# ulang(psutil.net_connections())
# ulang(psutil.net_if_addrs())
# ulang(psutil.net_if_stats())

# Prosess Manager 
# ulang(psutil.pids())
# for i in (psutil.pids()):
#     p = psutil.Process(i)
#     # print(p.name)
#     print(p.connections)

# P   = psutil.pids()
PP  = psutil.Process(6396)
print(PP)
print(PP.name())
print(PP.connections())
print(PP.exe)
print(PP.status())
print(PP.memory_full_info())
print(PP.environ())
print(PP.as_dict())