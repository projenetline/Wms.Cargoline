// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function baseUrl() {
    var href = window.location.href.split("/");
    var url = "";
    url = href[0] + "//" + href[2];
    return url;
}
//$(document).ready(function () {
//    window.addEventListener("load", function () {
//        var now = new Date();
//        var utcString = now.toISOString().substring(0, 19);
//        var year = now.getFullYear();
//        var month = now.getMonth() + 1;
//        var day = now.getDate();
//        var hour = now.getHours();
//        var minute = now.getMinutes();
//        var localDatetime = year + "-" +
//            (month < 10 ? "0" + month.toString() : month) + "-" +
//            (day < 10 ? "0" + day.toString() : day) + "T" +
//            (hour < 10 ? "0" + hour.toString() : hour) + ":" +
//            (minute < 10 ? "0" + minute.toString() : minute) +
//            utcString.substring(16, 19);
//        var datetimeField = document.getElementById("meeting-time");
//        datetimeField.value = localDatetime;
//    });
//});

//document.getElementById("search").addEventListener("keypress", function (e) {
//    console.log(e.keyCode);
//    if (e.keyCode != 13) {

//    }
//    e.preventDefault();
//});

//const BarcodeRead = (event) => {
//    console.log(event.keyCode);
//    if (event.keyCode === 13 || event.key === 'Enter') {
//        //event.preventDefault();
//        $.ajax({
//            type: 'get',
//            url: '/StartShipping/BarcodeRead',
//            contentType: 'application/json',
//            Headers: {
//                Authorization: 'Bearer' + token
//            },
//            dataType: 'text',
//        });
//    }
//}

//document.getElementById("search").addEventListener("keyup", function (event) {
//    console.log(event.keyCode);
//    if (event.keyCode === 13 || event.key === 'Enter') {
//        //event.preventDefault();
//        $.ajax({
//            type: 'get',
//            url: '/StartShipping/BarcodeRead',
//            contentType: 'application/json',
//            Headers: {
//                Authorization: 'Bearer' + token
//            },
//            dataType: 'text',
//        });
//    }
//})

//$('#search').on('keydown', function (e) {
//    console.log(e.key);
//    if (e.key == 'Enter') {
//        console.log('Entered');
//    }
//});


//const node = document.getElementById("search")[0];
//node.addEventListener("keyup", function (event) {
//    console.log(event.key)
//    console.log(even.key)
//    if (event.key === "Enter") {
//        // Do work
//    }
//})

//$("#search").on('keyup', function (e) {
//    console.log()
//    if (e.key === 'Enter' || e.keyCode === 13) {
//        // Do something
//    }
//});

const jwt = "";
document.getElementById("")
const SevkList = () => {
    $.ajax({
        type: 'get',
        url: '/ShippingList/Index',
        contentType: 'application/json',
        Headers: {
            Authorization:'Bearer'+token
            },
        dataType: 'text',
    });     
}
const SevkOnay = () => {
    $.ajax({
        type: 'post',
        url: '/StartShipping/Privacy?numberId=' + id,
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
const ErrorBarcode = () => {

}










function Sweet1(id) {
    console.log("Methoda girdi");
    $.ajax({
        type: 'post',
        url: '/Home/Privacy?numberId=' + id,
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
                    },
                    Error: function (data) {

                    }
                })
            }
        }
    })
}