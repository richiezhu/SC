
function isUndefined(variable) {
    return typeof variable == 'undefined' ? true : false;
}

//dt: /Date(1405008000000)/
//format: 扩展参数，暂时未扩展
//return yyyy-MM-dd
function datetimestrformat(dt, format) {
    var mydatetime = eval('new ' + dt.replace(/[/]/g, ''));
    return datetimeformat(mydatetime, format);
}

function datetimeformat(mydatetime, format) {
    format = isUndefined(format) ? 'yyyy-MM-dd' : format;
    var o = {
        "M+": (mydatetime.getMonth() + 1), //month
        "d+": mydatetime.getDate(), //day
        "h+": mydatetime.getHours(), //hour
        "m+": mydatetime.getMinutes(), //minute
        "s+": mydatetime.getSeconds(), //second
        "q+": Math.floor((mydatetime.getMonth() + 3) / 3), //quarter
        "S": mydatetime.getMilliseconds() //millisecond
    }
    if (/(y+)/.test(format)) {
        format = format.replace(RegExp.$1, (mydatetime.getFullYear() + "").substr(4 - RegExp.$1.length));
    }
    for (var k in o) {
        if (new RegExp("(" + k + ")").test(format)) {
            format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? o[k] : ("00" + o[k]).substr(("" + o[k]).length));
        }
    }
    return format;
}