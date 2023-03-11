function my_function(message) {
    console.log("From function in Utilities " + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("ComponentInActionBlazor.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript " + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}