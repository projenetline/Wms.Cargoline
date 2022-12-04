// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function baseUrl() {
    var href = window.location.href.split("/");
    var url = "";
    url = href[0] + "//" + href[2];
    return url;
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
                    }
                })
            }
        }
    })
}