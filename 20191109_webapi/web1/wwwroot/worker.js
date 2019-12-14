

onmessage = function(e) {
    var no = e.data;
    setInterval(() => {
        this.postMessage(no++);
    }, 1000);
}
