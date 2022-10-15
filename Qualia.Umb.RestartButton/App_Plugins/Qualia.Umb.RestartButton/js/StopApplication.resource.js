function StopApplicationResource($q, $http, umbRequestHelper) {

    return {
        stopApp: function () {
            return umbRequestHelper.resourcePromise(
                $http.post("/umbraco/backoffice/api/StopApplication/Execute"), "Failed to stop app.");
        }
    };
}
angular.module("umbraco.resources").factory("StopApplicationResource", StopApplicationResource);