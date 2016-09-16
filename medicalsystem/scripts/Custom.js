

//Company name existing name and button service start
function CompanyNameEdit() {
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
//Company existing name and button end


// Medicine Type name and button start
function TypeName() {
    $(document).ready(function () {

        $('#txtUserName').keyup(function () {
            var TypeName = $(this).val();

            if (TypeName.length >= 3) {
                $.ajax({
                    url: '/WebServices/MedicineType.asmx/MedicineTypeExists',
                    method: 'post',
                    data: { TypeName: TypeName },
                    dataType: 'json',
                    success: function (data) {
                        var divElement = $('#divOutput');
                        if (data.TypeNameInUse) {
                            divElement.text(data.TypeName + ' already in use');
                            divElement.css('color', 'red');
                        }
                        else {
                            divElement.text(data.TypeName + ' available')
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

function TypeNameButton() {
    $(document).ready(function () {


        $('#txtUserName').keyup(function () {
            var TypeName = $(this).val();

            if (TypeName.length >= 3) {
                $.ajax({
                    url: '/WebServices/MedicineType.asmx/MedicineTypeExists',
                    method: 'post',
                    data: { TypeName: TypeName },
                    dataType: 'json',
                    success: function (data) {

                        if (data.TypeNameInUse) {
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

function TypeNameEdit() {
    $(document).ready(function () {
        var bla = $('#txtUserName').val();
        $('#txtUserName').keyup(function () {
            var TypeName = $(this).val();

            if (TypeName.length >= 3) {
                $.ajax({
                    url: '/WebServices/MedicineType.asmx/MedicineTypeExists',
                    method: 'post',
                    data: { TypeName: TypeName },
                    dataType: 'json',
                    success: function (data) {
                        var divElement = $('#divOutput');
                        if (TypeName == bla) {
                            divElement.text(data.TypeName + ' availableeee');
                            divElement.css('color', 'green');

                        }
                        else if (data.TypeNameInUse) {
                            divElement.text(data.TypeName + ' already in use');
                            divElement.css('color', 'red');
                        }
                        else {
                            divElement.text(data.TypeName + ' available')
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
function TypeNameEditButton() {
    $(document).ready(function () {
        var bla = $('#txtUserName').val();
        $('#txtUserName').keyup(function () {
            var TypeName = $(this).val();

            if (TypeName.length >= 3) {
                $.ajax({
                    url: '/WebServices/MedicineType.asmx/MedicineTypeExists',
                    method: 'post',
                    data: { TypeName: TypeName },
                    dataType: 'json',
                    success: function (data) {
                        var divElement = $('#divOutput');
                        if (TypeName == bla) {

                            $('#btnDiv').show('fast');
                        }
                        else if (data.TypeNameInUse) {
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
