# RasPBX_Build
Documentation for RasPBX Build with Cisco 7941G IP Phones

The inspiration for this project was the [MagPi 78](https://magpi.raspberrypi.org/issues/78) article “[Build a telephone exchange](https://magpi.raspberrypi.org/articles/raspberry-pi-telephone-exchange).” I ran into issues with this build and did not listen to the advise of others to throw out the phones and gets some newer ones which are supported and can be easily configured.

My advise is if you have Cisco 7941G phones, it is possible to get them to work and it is not too bad once you understand how to configure them and get them to work. If you do not have these phones then I would advise you to move along and get a newer phone because the Cisco 7941G phones are not for the faint of heart. They are difficult but not impossible to setup. Hopefully the information that I have collected and am sharing here will help you to configure your RasPBX/FreePBX instalation to work with the Cisco 7941G IP phones.

**Hardware for my build (Not all of it is necessary)**
- Raspberry Pi 4 4GB
- 16GB MicroSD Card
- Raspberry Pi 15.3W USB-C Power Supply 
- PoE Ethernet Hub (Tenda  Model TEF1110P-8-63W)
- PoE+ Injector Adapter (Cudy POE150)
- Cisco CP-7941G Unified VoIP IP Phones
- Obihai OBi110 Voice Service Bridge and VoIP Telephone Adapter

**Software used**
- RasPBX - [http://www.raspberry-asterisk.org/](http://www.raspberry-asterisk.org/)
- Open79XX XML Directory - [https://sourceforge.net/projects/open79xxdir/](https://sourceforge.net/projects/open79xxdir/) ***NOTE** The version included here is heavily modified to fix some bugs and allowed it to work with PHP 7.*
