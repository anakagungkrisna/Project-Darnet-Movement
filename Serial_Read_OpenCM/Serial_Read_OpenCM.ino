
int i = 0;
int j;
int num;

int cekData = 0;

//dibawah ini adalah blok data secara keseluruhan
int data[30];
char x,y,z,angle,setA2,a,mirror;
int numx[3],numy[3],numz[3],numangle[3],numsetA2[3],numa[3],nummirror;
int Numx,Numy,Numz,Numangle,NumsetA2,Numa,Nummirror;


void setup(){
  SerialUSB.begin(); //inisiasi koneksi serialUSB
}


int connectSerial(int i, int value[]) {
  for(j = 0; j <= i; j++) {
    if(value[j] == 115 ) {
      if(value[j+1] == 101) {
        if(value[j+2] == 114) {
          if(value[j+3] == 105) {
            if(value[j+4] == 97) {
              if(value[j+5] == 108) {
              SerialUSB.println("Serial connection established");
              delay(3000);
              }
            }
          }
        }
      }
    }  
  }
  for(j = 0; j <= i; j++) {
     if(value[j] == 101 ) {
       if(value[j+1] == 120 ) {
         if(value[j+2] == 105 ) {
           if(value[j+3] == 116 ) {
             SerialUSB.println("Disconnecting Serial Connection");
             delay(3000);
             //dibawah ini untuk nge-reset ke nilai 0 untuk seluruh nilai data[]
             value[j] = 0;
             value[j+1] = 0;
             value[j+2] = 0;
             value[j+3] = 0; 
           }
         }
       }
     }
   }
}

void getData(int value[]) {
   while(SerialUSB.available()) { //ngambil data selama serialUSB ada data pending
    //print it out though USART2(RX2,TX2)

    value[i] = SerialUSB.read(); //ambil data one by one
    SerialUSB.print((char)value[i]); //print data dalam blok memori data[]
    //                ^ untuk nampilin ASCII dalam bentu char. kalau (int) bakal nampilin ASCII dalam bentuk desimal
    SerialUSB.print("   ");
    SerialUSB.println(i); //print nilai blok memori saat itu
    i++;  //nambah nilai blok memori untuk memasukkan data di blok data[] berikutnya
  }
  i = 0; //SANGAT PENTING!! untuk nge reset blok data mulai dari data[0] lagi
}

int processData(int data[]) {
  if(data[0] == 0 && data[1] == 0 && data[2] == 0) return 0;//bila return 0, data[] masih kosong
  
  x = data[0];
  if(x != 'x')return -1;//cek kondisi, data pertama yg diterima harus x
  numx[0] = data[1] - 48;
  numx[1] = data[2] - 48;
  numx[2] = data[3] - 48;
  Numx = numx[0]*10*10 + numx[1]*10 + numx[2];
  
  if(data[4] != 59)return -1;//kalo datanya NULL, ga dianggap salah
  
  y = data[5];//y ngasilin char dari hasil int nya ASCII karna typenya y itu char
  if(y != 'y')return -1;//cek kondisi, data kelima harus y atau '121' which is ASCII nya y;
  numy[0] = data[6] - 48;
  numy[1] = data[7] - 48;
  numy[2] = data[8] - 48;
  Numy = numy[0]*10*10 + numy[1]*10 + numy[2];
  
  if(data[9] != 59) return -1;//kalo datanya NULL, ga dianggap salah
  
  z = data[10];
  if(z != 'z')return -1;//cek data, data kesepuluh harus z
  numz[0] = data[11] - 48;
  numz[1] = data[12] - 48;
  numz[2] = data[13] - 48;
  Numz = numz[0]*10*10 + numz[1]*10 + numz[2];
  
  if(data[14] != 59) return -1;//kalo datanya NULL, ga dianggap salah
  
  return 1;//bila return 1; data yang diterima formatnya benar
}

void loop(){
  // when you typed any character in terminal
  //if(SerialUSB.available()) {
    
  //selama gak ada data yg masuk, data gak berubah

  getData(data);
  
  connectSerial(i,data); /*jika data[0] sampe data[5] 
  isinya s,e,r,i,a,l maka akan kekoneksi ke serial. jika data[0]
  sampe data[3] isinya e,x,i,t makan akan diskonek*/
  
  cekData = processData(data);
  SerialUSB.print("Status kebenaran data: ");
  SerialUSB.println(cekData);
  
  //Kode dibawah ini akan nge-reset seluruh data apabila mendapatkan data yang tidak dikenal
  if(cekData == -1) {
    SerialUSB.println("Unrecognized type of data");
    for(j = 0; j<=20; j++) {
     data[j] = 0; 
    }
    for(j = 0; j<=2; j++) {
      numx[j] = 0;
      numy[j] = 0;
      numz[j] = 0;
    }  
    Numx = 0;
    Numy = 0;
    Numz = 0;
  }
  
  if(cekData == 0)SerialUSB.println("Pending for data");
  
  SerialUSB.print(x);
  SerialUSB.println(Numx);
  SerialUSB.print(y);
  SerialUSB.println(Numy);
  SerialUSB.print(z);
  SerialUSB.println(Numz);
  
  delay(1000);
  
}
