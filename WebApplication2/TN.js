
$(document).ready(function () {

    function gui_api() {
        var data = {
            a: $('#TextBox1').val(),
        };
        if (data.a==''|| isNaN(data.a)) {
            $('#ketqua_web').html('Lỗi: Kiểm tra lại giá trị.');
            $('#TextBox1').focus();
            return;
        }
        $('ketqua_web').html('Đang gửi API...');

        $.post(api.aspx",
            data,
            function (kq, status) {
                if (status == "success") {
                    //
                    $('#ketqua_web').html(kq);
                }
            });
    }
    $("#Button1").click(function () {
        gui_api();
    });
});