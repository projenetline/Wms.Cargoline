$(document).ready(function () {

    $('#Barcode').focus();

    $('#Barcode').on('keypress', function (event) {
        if (event.which === 13) {
            event.preventDefault();
            debugger
            //Disable textbox to prevent multiple submit
            var barcode = $(this).val();
            var amount = parseFloat($('#Amount').val());

            var table = document.getElementById('ShipmentTable');

            var rowLength = table.rows.length - 1;

            var isFounded = false;


            var isOrderAmountFinished = false;


            for (var i = 0; i < rowLength; i += 1) {

                var rowBarcode = $('#Items_' + i + '__Barcode').val();



                if (rowBarcode === barcode) {

                    isFounded = true;


                    var orderAmount = parseFloat($('#Items_' + i + '__OrderAmount').val());
                    var shippedAmount = parseFloat($('#Items_' + i + '__Shipped').val());


                    shippedAmount = shippedAmount + amount;
                    if (orderAmount >= shippedAmount) {
                        $('#Items_' + i + '__Barcode').attr('style', 'background-color:#53d0e9 !Important');
                        $('#Items_' + i + '__Shipped').val(shippedAmount.toString());

                        var leftAmount = orderAmount - shippedAmount;

                        $('#Items_' + i + '__LeftAmount').val(leftAmount.toString());


                        $('#Items_' + i + '__LeftAmount').attr('style', 'background-color:coral !Important;text-align:center');
                        $('#Items_' + i + '__Shipped').attr('style', 'background-color:coral !Important;text-align:center');

                        $('#Items_' + i + '__OrderAmount').attr('style', 'background-color:coral !Important;text-align:center');
                        $('#Items_' + i + '__ItemCode').attr('style', 'background-color:coral !Important');
                        $('#Items_' + i + '__ItemName').attr('style', 'background-color:coral !Important');
                        $('#Items_' + i + '__UnitCode').attr('style', 'background-color:coral !Important');
                        $('#Items_' + i + '__LotNr').attr('style', 'background-color:coral !Important');


                        if (orderAmount === shippedAmount) {

                            SetSuccessColorAll(i);
                        }





                        const audio = new Audio(baseUrl() + "/assets/sounds/ok.mp3");
                        // audio.play();

                        SetSuccessColor(i);
                        i = rowLength;
                        isOrderAmountFinished = false;
                    }
                    else {


                        isOrderAmountFinished = true;


                    }
                    SetTotalAmount();
                }

            }
            if (!isFounded) {

                $(this).css('background-color', 'coral');
            }

            if (isOrderAmountFinished) {

                alert("Sipariş sayısına ulaşıldı..");
            }

        }
    });

})
function SetTotalAmount() {
    var table = document.getElementById('ShipmentTable');
    var shippedAmount = 0;
    var rowLength = table.rows.length - 1;
    for (var i = 0; i < rowLength; i += 1) {

        shippedAmount = shippedAmount + parseFloat($('#Items_' + i + '__Shipped').val());

    }
    $('#txtTotalShipmentAmount').text("Sevk Edilen Toplam Adet : " + shippedAmount.toString());

    var orderaAount = parseFloat($('#TotalAmount').val());
    if (shippedAmount === orderaAount) {

        $("#btnCompleteShipment").removeAttr("disabled");
    }



}
function SetSuccessColor(rowNr) {
    setTimeout(function () {

        var leftAmount = parseFloat($('#Items_' + rowNr + '__LeftAmount').val());

        if (leftAmount === 0) {

            $('#Items_' + rowNr + '__Barcode').attr('style', 'background-color:lightgreen !Important');
            $('#Items_' + rowNr + '__Shipped').attr('style', 'background-color:lightgreen !Important;text-align:center')
            $('#Items_' + rowNr + '__OrderAmount').attr('style', 'background-color:lightgreen !Important;text-align:center');
            $('#Items_' + rowNr + '__ItemCode').attr('style', 'background-color:lightgreen !Important');
            $('#Items_' + rowNr + '__ItemName').attr('style', 'background-color:lightgreen !Important');
            $('#Items_' + rowNr + '__UnitCode').attr('style', 'background-color:lightgreen !Important');
            $('#Items_' + rowNr + '__LotNr').attr('style', 'background-color:lightgreen !Important');

            $('#Items_' + rowNr + '__LeftAmount').attr('style', 'background-color:coral !Important;text-align:center');
        }
        else {

            $('#Items_' + rowNr + '__LeftAmount').attr('style', 'background-color:#53d0e9 !Important;text-align:center');
            $('#Items_' + rowNr + '__Shipped').attr('style', 'background-color:#53d0e9 !Important;text-align:center')
            $('#Items_' + rowNr + '__OrderAmount').attr('style', 'background-color:#53d0e9 !Important;text-align:center');
            $('#Items_' + rowNr + '__ItemCode').attr('style', 'background-color:#53d0e9 !Important');
            $('#Items_' + rowNr + '__ItemName').attr('style', 'background-color:#53d0e9 !Important');
            $('#Items_' + rowNr + '__UnitCode').attr('style', 'background-color:#53d0e9 !Important');
            $('#Items_' + rowNr + '__LotNr').attr('style', 'background-color:#53d0e9 !Important');
        }



    }, 200);
}
function SetSuccessColorAll(rowNr) {
    setTimeout(function () {

        $('#Items_' + rowNr + '__OrderAmount').attr('style', 'background-color:#53d0e9 !Important;text-align:center');
        $('#Items_' + rowNr + '__ItemCode').attr('style', 'background-color:#53d0e9 !Important');
        $('#Items_' + rowNr + '__ItemName').attr('style', 'background-color:#53d0e9 !Important');
        $('#Items_' + rowNr + '__UnitCode').attr('style', 'background-color:#53d0e9 !Important');
        $('#Items_' + rowNr + '__LotNr').attr('style', 'background-color:#53d0e9 !Important');

    }, 200);
}




function SetShippedAll() {
    var table = document.getElementById('ShipmentTable');

    var rowLength = table.rows.length - 1;
    for (var i = 0; i < rowLength; i += 1) {




        var orderAmount = parseFloat($('#Items_' + i + '__OrderAmount').val());
        $('#Items_' + i + '__Shipped').val(orderAmount.toString());
        $('#Items_' + i + '__LeftAmount').val("0");

        $('#Items_' + i + '__Barcode').attr('style', 'background-color:lightgreen !Important');
        $('#Items_' + i + '__LeftAmount').attr('style', 'background-color:lightgreen !Important;text-align:center');
        $('#Items_' + i + '__Shipped').attr('style', 'background-color:lightgreen !Important;text-align:center');
        $('#Items_' + i + '__OrderAmount').attr('style', 'background-color:lightgreen !Important;text-align:center');
        $('#Items_' + i + '__ItemCode').attr('style', 'background-color:lightgreen !Important');
        $('#Items_' + i + '__ItemName').attr('style', 'background-color:lightgreen !Important');
        $('#Items_' + i + '__UnitCode').attr('style', 'background-color:lightgreen !Important');
        $('#Items_' + i + '__LeftAmount').attr('style', 'background-color:coral !Important;text-align:center');
        $('#Items_' + i + '__LotNr').attr('style', 'background-color:lightgreen !Important');

    }


    var orderaAount = parseFloat($('#TotalAmount').val());
    $('#txtTotalShipmentAmount').text("Sevk Edilen Toplam Adet : " + orderaAount.toString());


    $("#btnCompleteShipment").removeAttr("disabled");



}

function baseUrl() {


    var href = window.location.href.split("/");

    var url = "";

    url = href[0] + "//" + href[2];
    return url;
}
function concateOrdersModal(orderId, clDef, clCode) {


    $('#OrderlistModalTitle').text(clDef + " carisine ait aynı seriden siparişleri seçebilirsiniz.");
    $('#txtOrderId').val(orderId);



    var hasOrders = false;

    $.ajax({
        type: "GET",
        url: "http://localhost/api/Shipment/GetShipmentList?FirmNr=1",
        dataType: "json",
        async: false,
        success: function (response) {

            var html = "";

            var rowNr = 0;


            for (var i = 0; i < response.length; i++) {

                if (clCode === response[i].clCode && orderId != response[i].orderId) {

                    hasOrders = true;
                    var dateStr = new Date(response[i].date).toLocaleDateString();

                    html = html + "   <tr>";
                    html = html + "   <td>";
                    html = html + "   <div class=\"checkbox-custom checkbox-primary\">";
                    html = html + "   <input checked type=\"checkbox\" value=\"" + response[i].orderId + "\" id=\"chkBoxShipment_" + rowNr + "\">";
                    html = html + "   <label for=\"inputUnchecked\"></label>";
                    html = html + "   </div>";
                    html = html + "   </td > ";
                    html = html + "   <td>" + dateStr + "</td>";
                    html = html + "   <td>" + response[i].orderNr + "</td>";
                    html = html + "   <td>" + response[i].clDef + "</td>";



                    html = html + "    </tr>";
                    rowNr = rowNr + 1;
                }
            }
            $("#orderlistTableBody").html(html);





        }
    });


    if (hasOrders) {
        $('#OrderlistModal').modal('show');
    }
    else {
        var OrderList = [];


        OrderList.push(orderId);
   
        postForm(baseUrl() + '/ShippingList/Shipping', { OrderList: OrderList }, "Get");
      //  window.location.href = baseUrl() + '/ShippingList/Shipping?OrderId=' + orderId;
    
    }






}
function NotSelectOrders() {

    var OrderList = [];
    var orderId = $('#txtOrderId').val();
   
   // window.location.href = baseUrl() + '/ShippingList/Shipping?OrderId=' + orderId;



    OrderList.push(orderId);

    postForm(baseUrl() + '/ShippingList/Shipping', { OrderList: OrderList }, "Get");

}
function SelectOrders() {
    var id = $('#txtOrderId').val();
    var OrderList = [];

    OrderList.push(id);
    var table = document.getElementById('orderlistTable');

    var rowLength = table.rows.length - 1;

    for (var i = 0; i < rowLength; i++) {

        if ($("#chkBoxShipment_" + i).is(':checked')) {
            var orderid = $("#chkBoxShipment_" + i).val();
            OrderList.push(orderid);
            
        }
        else {
            alert("unchecked");
        }

      
    

        
    }
    postForm(baseUrl() + '/ShippingList/Shipping', { OrderList: OrderList },"Get");
    //$.ajax({
    //    type: "POST",
    //    url: baseUrl() + '/ShippingList/Shipping',
    //    data: { OrderList: OrderList },
    //    success: function (response) {

    //    }
    //});


} function postForm(path, params, method) {
    method = method || 'post';

    var form = document.createElement('form');
    form.setAttribute('method', method);
    form.setAttribute('action', path);

    for (var key in params) {
        if (params.hasOwnProperty(key)) {
            var hiddenField = document.createElement('input');
            hiddenField.setAttribute('type', 'hidden');
            hiddenField.setAttribute('name', key);
            hiddenField.setAttribute('value', params[key]);

            form.appendChild(hiddenField);
        }
    }

    document.body.appendChild(form);
    form.submit();
}

