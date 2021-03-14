(function () {
    $.connection.hub.start()
        .done(function () {
            console.log("It worked")
            $.connection.myHub.server.announce("Connected");
        })
        .fail(function () { alert("Its not working") });

    $.connection.myHub.client.announce = function (message) {
        alert(message);
    }
})()