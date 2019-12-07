onmessage = function(e) {
  var no = e.data;
  this.console.log(no); 
  this.postMessage(no+1);   
}