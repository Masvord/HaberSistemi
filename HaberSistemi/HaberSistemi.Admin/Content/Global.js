function KategoriEkle() {
    var Kategori = {}; //Obje oluşturur.

    
    Kategori.KategoriAdi = $("#KategoriAdi").val();
    Kategori.URL = $("#KategoriUrl").val();
    Kategori.AktifMi = $("KategoriAktif").is(":checked"); //Boşluk karakteri kaldırıldı.
    Kategori.ParentID = $("#ParentID").val();


    $.ajax({
        url: "/Kategori/Ekle",
        data: JSON.stringify(Kategori), //Kategori nesnesi JSON formatına dönüştürüldü
        type: "POST",
        dataType: "json",
        success: function (response) {
            if (response.Success) {
                bootbox.alert(response.Message, function () {
                    location.reload();
                });
            } else {
                bootbox.alert(response.Message, function () {
                    //Geri döndüğünde bir tepki vermesini istersek buraya yazılır.

                });
            }
        }
    })
}