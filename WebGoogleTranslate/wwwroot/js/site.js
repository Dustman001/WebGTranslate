// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var pl = document.getElementById("PagLang");
var sl = document.getElementById("SrcLang");
var tl = document.getElementById("TrgLang");

var ps = document.getElementById("PagLangSet");
var ss = document.getElementById("SrcLangSet");
var ts = document.getElementById("TrgLangSet");

var idm = document.getElementById('idm');
var pgo = document.getElementById('pgo');
var pgd = document.getElementById('pgd');

var to = document.getElementById("T_Org");
var tos = document.getElementById("T_OrgSet");

function Translate() {

    if (tos.value !== to.value || ts.value !== tl.value) {
        tos.value = to.value;
        ss.value = sl.value;
        ts.value = tl.value;

        //document.getElementById('T_dest').value = 'Hasta aqui llega! ' + new Date() + ' tos=' + tos.value + ' to=' + to.value;

        fetch('Home/TranslateApi?sl=' + sl.value + '&tl=' + tl.value + '&tx=' + to.value).then(response => response.json())
            .then(json => {
                document.getElementById('T_dest').value = json[0];
            });
    }

    setInterval(Translate, 3000);
}

function PageLangs(val) {

    fetch('Home/TranslateApi?tl=' + pl.value).then(response => response.json())
        .then(json => {

            idm.innerText = json[0];
            pgo.innerText = json[1];
            pgd.innerText = json[2];

            ps.value = pl.value;
            //document.getElementById("unmode1").innerText = 'Lenguaje: ' + json[0] + ', Origen: ' + json[1] + ', Destino: ' + json[2];
        });
}

window.onload = function () {

};

tos.value = to.value;
ps.value = pl.value;
ss.value = sl.value;
ts.value = tl.value;

Translate();

setInterval(Translate, 3000);