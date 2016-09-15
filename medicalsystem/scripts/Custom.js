<<<<<<< HEAD
﻿
=======
﻿function CompanyNameEdit() {
    $(document).ready(function () {
        var bla = $('#txtUserName').val();
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
                        if (userName == bla) {
                            divElement.text(data.UserName + ' availableeee');
                            divElement.css('color', 'green');
                        
                        }
                        else if (data.UserNameInUse) {
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

function CompanyNameEditButton() {
    $(document).ready(function () {
        var bla = $('#txtUserName').val();
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
                        if (userName == bla) {
                            
                            $('#btnDiv').show('fast');
                        }
                        else if (data.UserNameInUse) {
                            $('#btnDiv').hide('fast');
                        }
                        else {
                            $('#btnDiv').show('fast');
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



function CompanyNameButton() {
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

                        if (data.UserNameInUse) {
                            $('#btnDiv').hide('fast');
                        }
                        else {
                            $('#btnDiv').show('fast');
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
>>>>>>> bf8412f69b048ce8ae7ea04188d3acfa22108bba
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
<<<<<<< HEAD
}
=======
}

>>>>>>> bf8412f69b048ce8ae7ea04188d3acfa22108bba
