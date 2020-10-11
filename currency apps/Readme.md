# Currency apps
aplikasi ini mencangkup fungsi menghitung nilai tukar mata uang dari dolar ke rupiah . satu dollar dianggap senilai  Rp.15.000
## scope & Functionalities
-user dapat memasukan angka
-user dapat menyentuh tombol hitung 
-user mendapatkan info "INVAILID" jika yang dimasukan berupa text
## How Does it works?

diawali dari method'mainwindow

'''c#

 public MainWindow()

        {
            InitializeComponent();
            currency = new CurrencyController();
        }

'''
logika perhitungan terdapat pada cllas CurrencyController.cs sebagai berikut
cara kerjanya  pertama masukan angka lalu tekan tombol hitung dang angka tersebut akan di proses 

'''c#

 public string usdToIdr(string nominal)
      
   {
          
            var nominalDouble = Convert.ToDouble(nominal);
            var result = nominalDouble * 15000;
            return Convert.ToString(result);
   }

'''