function StopApplicationController(StopApplicationResource, notificationsService) {

    var vm = this;
    vm.stopApp = stopApp;

    function stopApp() {
        StopApplicationResource.stopApp().then(
            (result) => { notificationsService.success("Success", "The application has been stopped.") },
            () => notificationsService.error("Stopping the app failed", "An error prevented the process!")
        );
    }
}

angular.module("umbraco").controller("StopApplicationController", StopApplicationController);