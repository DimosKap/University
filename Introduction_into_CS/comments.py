filen=input("please insert file's name: ")
fin=open(filen,"r")
lines=fin.readlines()
fin.close()

fin=open(filen,"w")
for line in lines:
	if "#" in line:
		l=line.strip()
		if l[0]!="#":
			tmp=line.split("#")
			a1=tmp[0].count("'")
			a2=tmp[0].count('"')
			comandf=[]
			cominp=[]
			func=[]
			if a1%2==1 or a2%2==1:
				cominp.append(line)
				for x in range(len(cominp)):
					fin.write(cominp[x])
					fin.write("\n")

			else:
				y=line.split("#")[0]
				comandf.append(y)
				for x in range(len(comandf)):
					fin.write(comandf[x])
					fin.write("\n")
	else:
			fin.write(line)
			fin.write("\n")
print("Enjoy your free of comments code!! :)")
fin.close()
