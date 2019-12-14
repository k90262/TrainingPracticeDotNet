function add() {
    var s1 = document.getElementById("no1").value;
    var s2 = document.getElementById("no2").value;
    var no1 = parseFloat(s1);
    var no2 = parseFloat(s2);
    var answer = no1 + no2;
    document.getElementById("answer").innerHTML = answer;
}
