
function doJson() {
    debugger;
    alert('json!');
    $.getJSON("http://localhost:4640/api/customer",
     function (data) {
         alert(data);
     });
}

function doAjax() {
    debugger;
    alert('ajax!');
    $.ajax({
        type: "GET",
        dataType: "json",
        url: "http://localhost:4640/api/customer/get",
        success: function (data) {
            alert(data);
        },
        error: function (data) {
            alert(data);
        }
    });
}