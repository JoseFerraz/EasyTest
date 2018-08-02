angular.module("easyTest").factory("modals", function () {
    return {
        alertResult: function (message, callback) {
            bootbox.alert({
                message: message,
                closeButton: false,
                backdrop: true,
                className: 'alert-result',
                buttons: {
                    ok: {
                        label: 'Ok',
                        className: 'alert-result-button'
                    }
                },
                callback: callback
            });
        },
        confirmAction: function (message, callback) {
            bootbox.confirm({
                message: message,
                closeButton: false,
                className: 'confirm-action',
                buttons: {
                    confirm: {
                        label: 'Confirm',
                        className: 'confirm-action-button-confirm'
                    },
                    cancel: {
                        label: 'Cancel',
                        className: 'confirm-action-button-cancel'
                    }
                },
                callback: callback
            });
        }
    };
});