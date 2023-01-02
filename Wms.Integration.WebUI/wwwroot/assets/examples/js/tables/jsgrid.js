(function (global, factory) {
    if (typeof define === "function" && define.amd) {
        define('/tables/jsgrid', ['jquery', 'Site'], factory);
    } else if (typeof exports !== "undefined") {
        factory(require('jquery'), require('Site'));
    } else {
        var mod = {
            exports: {}
        };
        factory(global.jQuery, global.Site);
        global.tablesJsgrid = mod.exports;
    }
})(this, function (_jquery, _Site) {
    'use strict';

    var _jquery2 = babelHelpers.interopRequireDefault(_jquery);

    (0, _jquery2.default)(document).ready(function ($$$1) {
        (0, _Site.run)();
    });

    jsGrid.setDefaults({
        tableClass: "jsgrid-table table table-striped table-hover"
    });

    jsGrid.setDefaults("text", {
        _createTextBox: function _createTextBox() {
            return (0, _jquery2.default)("<input>").attr("type", "text").attr("class", "form-control input-sm");
        }
    });

    jsGrid.setDefaults("number", {
        _createTextBox: function _createTextBox() {
            return (0, _jquery2.default)("<input>").attr("type", "number").attr("class", "form-control input-sm");
        }
    });

    jsGrid.setDefaults("textarea", {
        _createTextBox: function _createTextBox() {
            return (0, _jquery2.default)("<input>").attr("type", "textarea").attr("class", "form-control");
        }
    });

    jsGrid.setDefaults("control", {
        _createGridButton: function _createGridButton(cls, tooltip, clickHandler) {
            var grid = this._grid;

            return (0, _jquery2.default)("<button>").addClass(this.buttonClass).addClass(cls).attr({
                type: "button",
                title: tooltip
            }).on("click", function (e) {
                clickHandler(grid, e);
            });
        }
    });

    jsGrid.setDefaults("select", {
        _createSelect: function _createSelect() {
            var $result = (0, _jquery2.default)("<select>").attr("class", "form-control input-sm"),
                valueField = this.valueField,
                textField = this.textField,
                selectedIndex = this.selectedIndex;

            _jquery2.default.each(this.items, function (index, item) {
                var value = valueField ? item[valueField] : index,
                    text = textField ? item[textField] : item;

                var $option = (0, _jquery2.default)("<option>").attr("value", value).text(text).appendTo($result);

                $option.prop("selected", selectedIndex === index);
            });

            return $result;
        }
    });

    (function () {
        var DateField = function (config) {
            jsGrid.Field.call(this, config);
        };

        DateField.prototype = new jsGrid.Field({
            sorter: function (date1, date2) {
                return new Date(date1) - new Date(date2);
            },
            itemTemplate: function (value) {
                return new Date(value).toLocaleDateString();
            },

            filterTemplate: function () {

                if (this.name === "date") {
                    var dtBegdate = new Date(new Date().getFullYear() - 2, 0, 1);
                    var dtEndDate = new Date(new Date().getFullYear(), 11, 31);
                    var endDate = "";// dtEndDate.toLocaleDateString();
                    var begDate = "";// dtBegdate.toLocaleDateString();
                    this._fromPicker = $("<input class=\"form-control\" value=\"" + begDate + "\" placeholder=\"Başlangıç Tarihi\">").datepicker();
                    this._toPicker = $("<input  class=\"form-control\" value=\"" + endDate + "\"  placeholder=\"Bitiş Tarihi\">").datepicker();


                    return $("<div>").append(this._fromPicker).append(this._toPicker);
                }


            },

            filterValue: function () {
                return {

                    from: this._fromPicker.datepicker("getDate"),
                    to: this._toPicker.datepicker("getDate")
                };
            },


        });

        jsGrid.fields.DateField = DateField;

        jsGrid.fields.date = DateField;
        debugger

        (0, _jquery2.default)('#ShipmentListViewTable').jsGrid({
            height: "720",
            width: "100%",

            filtering: true,
            editing: false,
            sorting: true,
            paging: true,
            autoload: true,
            pagerFormat: "Sayfalar: {first} {prev} {pages} {next} {last} &nbsp;&nbsp;  Toplam Kayıt: {itemCount}",
            loadMessage: "Lütfen Bekleyiniz...",
            pagePrevText: "Önceki",
            pageNextText: "Sonraki",
            pageFirstText: "İlk",
            pageLastText: "Son",
            pageSize: 50,
            pageButtonCount: 10,



            controller: {



                loadData: function (filter) {



                    var d = $.Deferred();



                    $.ajax({

                        type: "GET",

                        url: "http://localhost/api/Shipment/GetShipmentList?FirmNr=1",

                        data: filter,

                        dataType: "json"

                    }).done(function (result) {

                        result = $.grep(result, function (item) {

                            return item.orderNr.toUpperCase().includes(filter.orderNr.toUpperCase())
                                && item.clCode.toUpperCase().includes(filter.clCode.toUpperCase())
                                && item.clDef.toUpperCase().includes(filter.clDef.toUpperCase())
                                && item.projectType.toUpperCase().includes(filter.projectType.toUpperCase())

                        });

                        //if (filter.date.from !== null && filter.date.to !== null) {
                        //    result = $.grep(result, function (item) {
                        //        return new Date(item.date) <= filter.date.to && new Date(item.date) >= filter.date.from;

                        //    });

                        //}


                        d.resolve(result);

                    })


                    return d.promise();
                },

            },
            fields: [

                { name: "lineNr", title: "#", type: "text", width: 20, align: "center", search: false },
                { name: "date", title: "Tarih", type: "DateField" },
                { name: "orderNr", title: "Sipariş Numarası", type: "text" },
                { name: "clCode", title: "Cari Kodu", type: "text" },
                { name: "clDef", title: "Cari Unvan", type: "text", width: 200 },
                { name: "projectType", title: "Sipariş Türü", type: "text", width: 200 },
                {
                    type: "control", width: 50, editButton: false, deleteButton: false,
                    itemTemplate: function (value, item) {
                        var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);

                        var $customEditButton = $("<button>").attr({ class: "btn btn-info btn-xs" }).html("<i class=\"icon fa-edit\" aria-hidden=\"true\"></i>")
                            .click(function (e) {


                                concateOrdersModal(item.orderId, item.clDef, item.clCode);

                                //   window.location.href = baseUrl() + '/ShippingList/Shipping?OrderId=' + item.orderId;


                                e.stopPropagation();
                            });



                        return $("<div>").append($customEditButton);
                        //return $result.add($customButton);
                    },
                }


            ]
        });







        (0, _jquery2.default)(".views").on("change", function () {
            var $cb = (0, _jquery2.default)(this);
            (0, _jquery2.default)("#ShipmentListViewTable").jsGrid("option", $cb.attr("value"), $cb.is(":checked"));
        });


    })();
});


function baseUrl() {

    var href = window.location.href.split("/");

    var url = "";

    url = href[0] + "//" + href[2];
    return url;
}

