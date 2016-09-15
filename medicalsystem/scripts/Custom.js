
function CompanyName() {
    $(document).ready(function () {

        $('#txtUserName').keyup(function () {
            var userName = $(this).val();

            if (userName.length >= 3) {
                $.ajax({
                    url: '/WebServices/RegistrationService.asmx/UserNameExists',
                    method: 'post',
                    data: { userName: userName },
                    dataType: 'json',
                    success: function (data) {
                        var divElement = $('#divOutput');
                        if (data.UserNameInUse) {
                            divElement.text(data.UserName + ' already in use');
                            divElement.css('color', 'red');
                        }
                        else {
                            divElement.text(data.UserName + ' available')
                            divElement.css('color', 'green');
                        }
                    },
                    error: function (err) {
                        alert("error" + err);
                    }
                });
            }
        });
    });
}