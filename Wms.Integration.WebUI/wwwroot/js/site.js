// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function baseUrl() {
    var href = window.location.href.split("/");
    var url = "";
    url = href[0] + "//" + href[2];
    return url;
}
//const Menu = () => {
//    console.log("Methoda girdi");
//    Swal.fire({
//        html: '<br /><br /><br /><br />',
//        showConfirmButton: false,
//    })
//}
const SevkOnay = () => {
    Swal.fire({
        title: 'Kapatma işlemi gerçekleşsin mi?',
        showDenyButton: true,
        showCancelButton: false,
        confirmButtonText: 'Evet',
        denyButtonText: `Hayır`,
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            Swal.fire('Saved!', '', 'success')
        } else if (result.isDenied) {
            Swal.fire('Changes are not saved', '', 'info')
        }
    })
}
const BlogOpen =()=>{
    console.log("Methoda girdi");

    Swal.fire({
        html: '<br />><button class="btn btn-success" onclick="BlogOpen()" style="width:450px;height:50px">Blog İşlemi Yap</button><br /><br /><button onclick="RafOpen()" class="btn btn-danger" style="width:450px;height:50px">Raf İşlemi Yap</button><br/>',
        showConfirmButton: false,
    })
}
const RafOpen = () => {
    console.log("Methoda girdi");
    Swal.fire({
        html: '<br /><br /><button class="btn btn-success" onclick="BlogOpen()" style="width:450px;height:50px">Blog İşlemi Yap</button><br /><br /><button onclick="RafOpen()" class="btn btn-danger" style="width:450px;height:50px">Raf İşlemi Yap</button><br /><br />',
        showConfirmButton: false,
    })
}
const Menu2 = () => {
    console.log("Methoda girdi");

    Swal.fire({
        html: '<br /><br /><input type="text" id="1"  class="btn btn-success" onclick="BlogOpen()" style="width:450px;height:50px"/><br /><br /><button onclick="RafOpen()" class="btn btn-danger" style="width:450px;height:50px">Raf İşlemi Yap</button><br/><br/>',
        showConfirmButton: false,
        footer:'<div class="row" style="  width:100%;"><div class="col-lg-6"></div><div class="col-lg-3 float-end"><button class="btn btn-danger">Kapat</button></div><div class="col-lg-3 float-end"><button class="btn btn-danger">Vazgeç</button></div></div></div>'
    })
   
}
function Sweet1(id) {
    console.log("Methoda girdi");
    $.ajax({
        type: 'post',
        url:  '/Home/Privacy?numberId=' + id,
        contentType: 'application/text',
        dataType: 'text',
        success: function (data) {
            if (data) {
                Swal.fire(
                    'The Internet?',
                    'That thing is still around?',
                    'question'
                )
            }
            else {
                $.ajax({
                    type: 'Get/',
                    url: baseUrl + '/Home/Privacy',
                    contentType: 'application/text',
                    dataType: 'text',
                    success: function (data) {
                        if (data) {
                            Swal.fire(
                                'The Internet?',
                                'That thing is still around?',
                                'question'
                            )
                        }
                        else {

                        }
                    }
                })
            }
        }
    })

}