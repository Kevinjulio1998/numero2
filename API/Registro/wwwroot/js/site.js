
$('button#valuedata').click(function () {
    var url = 'https://localhost:5001/Home/Create';
    console.log(url);
    $('#modalBody').load(url);
});