R = 4 W= 2 X= 1 

Read 

Write

Execute


= 0 



cd /home/


systemctl stop firewalld.service (stopt firewall)


Mkdir SE3A (map aanmaken)


Ls 


ls -l 


groupadd se3a 


Chgrp se3a SE3A 


Chmod 770 SE3A 


Ls -l


useradd Akshay 


passwd Akshay 


smbpasswd -a Akshay 


usermod -g se3a Akshay 


id Akshay                         (CTRL C  eruit gaan)


zypper search samba 


systemctl start smb.service 

systemctl status smb.service 



vi /etc/samba/smb.conf



Akshay 

              path = /home/SE3A

              writeable = yes 



systemctl restart smb.service 





setfacl -m g:se3a:r-x se3b 



setfacl -m User Akshay se3a:r-x se3b 



zypper search apache2 



zypper install apache2



systemctl start apache2.service 



cd /srv/www/

Ls

mkdir vhosts 

cd vhosts/

Mkdir Akshay.nl gregga.com Lucas.org 

Ls 

vi Akshay.nl/index.html (hier kan je tekst in typen)

vi gregga.com/index.html 

vi lucas.org/index.html 



tree 



cd /etc/apache2/



cd /etc/apache2/vhosts.d



cp vhost.template Akshay.conf



vi Akshay.conf 


je doet ESC en daarna deze commando:

:1,$ s/dummy-host.example.com/Akshay.nl/g



vi /etc/hosts 

bij localhost daar onder je ip zetten en de naam van je website
voorbeeld: 127.0.0.1
192.168.150.134 Dimma.nl




systemctl restart apache2.service 



cd /home 



cd /tmp/

mkdir backup 

cd /home/

Vi backup.sh 


rsync -av  /home/SE3A  /tmp/backup

Ls -l 




chmod +x backup.sh 



Ls -l



./backup.sh 



crontab -e 



* * * * *

* minuten            0 â€“ 59

* uur van de dag     0 â€“ 24 

* dag van de maand   1 â€“ 31

* maand van het jaar 1 â€“ 12

* dag van de week    0 â€“ 6 (0 = zondag)


7 10 24 5 5 /home/backup.sh >> /home/logfiles



:wq! 


cd /tmp/

rm -r backup\ 





cat logfiles (in de home map)
