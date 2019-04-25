//用JavaScript弹出你的入栈口号

//alert("50K");

//利用JavaScript计算出：[(23 + 7)x12 - 8]÷6的值

//var nb = ((23 + 7) * 12 - 8) / 6;
//alert(nb);


////利用循环，计算出1 + 3 + 5 + 7 +...+99=?
//var sum = 0;
//for (var i = 1; i < 100; i += 2) {
//    sum += i;
//}
//alert(sum);
////使用JavaScript内置字符串函数，将 “‘源栈’：飞哥小班教学，线下免费收看” 变成：“大神"小"班教学，线上免费收看”。

//var yz = "‘源栈’：飞哥小班教学，线下免费收看";
//alert(yz);
//方法1
//var yz = yz.replace("‘源栈’：飞哥小班教学，线下", '大神"小"班教学，线上');
//alert(yz);

////方法2
//var yz1 = yz.slice(8);
//yz1[5] = "上";
//var yz2 = '大神"小"';
//var yz3 = yz2.concat(yz1);
//alert(yz3);
//var yz = '大神"小"班教学，线上免费收看';
//alert(yz);

////将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，所有字符串：
////首字母大写开头，其他字母小写
////截去超过6个字符的部分，如'community'将变成'Commun'

//var array = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
//for (var i = 0; i < array.length; i++) {
//    array[i] = array[i].toLowerCase();                    //全部转成小写
//    array[i] = array[i].replace(array[i][0], array[i][0].toUpperCase());    //首字母第一个大写，用哪个都行
//    array[i] = array[i][0].toUpperCase() + array[i].substring(1);     //首字母第一个大写，用哪个都行
//    array[i] = array[i].slice(0, 6);                //截去超过6个字符的部分
//};
//alert(array);


////将源栈同学姓名 / 昵称装入数组，再根据该数组输出共有多少同学

//var array = ['laocheng', 'xiaolong', 'laozhao', 'wenxuan', 'sixiwanzi',
//    'luwei', 'minghui', 'zixiang']
//for (var i = 0; i < array.length; i++) { }
//alert('源栈学生共有' + i + '人');

//////  在上述数组头部加上小雨老师，末尾加上大飞哥

//array.unshift('xiaoyu');
//array.push('dafeige');
//for (var i = 0; i < array.length; i++) {
//    alert(array[i]);
//}


////如果一个数只能被1和它自己整除，这个数就被称之为“素数”。请找出100以内的所有素数。
////然后封装成一个函数findPrime(max) ，可以返回max以内的所有素数。

//PrimeNumber(200);
//function PrimeNumber(max) {
//    var a = 0;
//    var array = new Array;
//    var newArray = new Array;
//    for (var i = 2; i < max + 1; i++) {        //取出最大值为max的所有数，
//        for (var q = 2; q < i; q++) {       //判断是否为素数，用传入数%比它小的数且大于1，都有余数则为素数。
//            if (i % q === 0) {                //如果不是素数给它赋值为0，
//                array[i - 3] = 0;
//                break;
//            } if (i % q !== 0) {
//                array[i - 3] = i;               //是素数取出，
//            }
//        }
//    }
//    array.unshift(2);                     // 把数组中为0的去掉，用新数组装结果，
//    for (var i = 0; i < array.length; i++) {
//        if (array[i] > 0) {
//            newArray[a] = array[i];
//            a++;
//        }
//    }
//    alert(newArray);
//}



////建立一个函数getMaxNumber() ，可以接受任意多各种类型（整数、小数、正数、负数、字符串、布尔值等）的参数，
////并找出里面最大的数（忽略其他类型）

//function getMaxNumber() {
//    var q = 0;
//    var array = new Array;                         //声明一个数组，
//    for (var i = 0; i < arguments.length; i++) {
//        //alert(arguments[i]);
//        if (typeof arguments[i] == "number") {        //判断是否为数字，
//            array[q] = arguments[i];
//            q++;
//        }
//    }
//    for (var a = 0; a < array.length; a++) {                 //取最大值，
//        alert(array[a]);
//        if (array[a] > array[a + 1]) {
//            array[a + 1] = array[a];
//        }
//    }
//    alert("最大值为：" + array[array.length - 1]);

//}
//getMaxNumber('name', 'age', 1, 2, 3);


////创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于100随机整数数组。

//function getRandomArray(length, max) {
//    var array = new Array(length);
//    for (var i = 0; i < length; i++) {
//        array[i] = (Math.floor(Math.random() * max));
//        array.sort();
//    }

//    for (var a = 0; a < length; a++) {
//        alert(array[a]);
//    }
//}
//getRandomArray(10, 100);

////删除一个数组里面重复的元素

//function drop(array) {
//    array.sort();                         // 排序，
//    var re = new Array;                        // 声明一个数组储存结果，
//    遍历数组，取出类型为String，进行比较，
//    for (var a = 0; a < array.length; a++) {
//        if (typeof array[a] === "string") {
//            if (array[a] != re[re.length - 1]) {
//                re.push(array[a]);
//            }
//        }
//    }
//    类型不为String进行比较。
//    for (var i = 1; i < array.length; i++) {
//        if (typeof array[i] !== "string") {
//            if (array[i] != re[re.length - 1]) {
//                re.push(array[i]);
//            }
//        }
//    }
//    return re;
//}
//alert(drop([1, "1", 1, 6, 2, 9, 2, 3, 13, 'abd', 13, 3, 4, '4', 4, 13, 'abd', 'abcd']));

////编写一个计算源栈返还红包金额的函数 Redbag()
////numberOfPeople为人数， Discount为折扣，


//function Redbag(numberOfPeople, Discount = 10) {
//    //1个人红包为19.80元，每增加一个人红包个数+19.80元，两个人红包个数为1,3个人为2，
//    var money;
//    if (numberOfPeople > 1) {
//        money = (numberOfPeople - 1) * 19.80 * Discount * 0.1;
//    } else {
//        alert("1个人没有红包哦！")
//    }
//    alert("本周你的红包为：" + money);
//}
//Redbag(11, 1);
//不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
//function inverted(text) {
//    var newtext = new String;
//    for (var i = 0; i < text.length; i++) {
//        newtext = newtext + text[text.length - i - 1];
//    }
//    alert(newtext);

//}
//inverted('hello,yuanzhan');
//统计出这段文字中有多少个单词：

//var text = 'There are two ways to create a RegExp object: a literal notation and a constructor.To indicate strings,the parameters to the literal notation do not use quotationarks while the parameters to the constructor function do use quotation- marks.So the following expressions create the same regular expression';
//text = text.replace(',', ' ');
//text = text.replace('.', ' ');
//text = text.replace('.', ' ');
//text = text.replace('-', ' ');
//var str = text.split(' ');
//alert('本文共有' + str.length + '个单词，感谢查阅。');

//在函数yz.fei.get986()中嵌入不带参数的函数has9() / has8() / has6() ，
//并调用上述函数，找出10000以内有多少个数字包含：9或者8或者6。

//var yz = {};
//yz.fei = {};
//yz.fei.get986 = function (get) {
//    var number1 = new Array();
//    var number2 = new Array();
//    var number3 = new Array();
//    function has9() {
//        for (var i = 0; i < get; i++) {
//            if (/[9]/.test(i)) {
//                number1[i] = i;
//            }
//        }
//    }
//    function has8() {
//        for (var j = 0; j < get; j++) {
//            if (/[8]/.test(j)) {
//                number2[j] = j;
//            }
//        }
//    }
//    function has6() {
//        for (var k = 0; k < get; k++) {
//            if (/[6]/.test(k)) {
//                number3[k] = k;
//            }
//        }
//    }
//    var number4 = number1.concat(number2);
//    var number5 = number4.concat(number3);
//    for (var m = 0; m < number5.length; m++) {
//        if (number5.indexOf(number5[m]) != m) {
//            number5.splice(m, 1);
//            m--;

//        }
//    }
//    alert(number5.length);

//    has9();
//    has6();
//    has8();



//    var a = 0;
//    for (var m = 1; m < get; m++) {
//        if (/[6]/.test(m) || /[8]/.test(m) || /[9]/.test(m)) {
//            a++;
//        }
//    }
//    alert(a);
//}
//yz.fei.get986(10000);

//function student() {
//    let name = 'laocheng', age = 18, female = 'false';
//    return {
//        StudentCard: function () {
//            alert(name + "   " + age + "   " + female);
//        }
//    }
//}
//var lc = student();
//lc.StudentCard();

//function foo(x) {
//    var tmp = 3;
//    return function (y) {
//        x = x ? x + 1 : 1;
//        console.log(x + y + tmp);
//    }
//}

//var bar = foo(-1)
//bar(10);



//说明： 解释变量，


//function buildList(list) {
//    var result = [];
//    for (let i = 0; i < list.length; i++) {
//        result.push(function () {
//            console.log('item' + i + ': ' + list[i])
//        });
//    }
//    return result;
//}

//(function () {
//    var fnlist = buildList([1, 2, 3]);
//    for (var i = 0; i < fnlist.length; i++) {
//        fnlist[i]();
//    }
//})();


//使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：
//第n周，源栈同学random人。（n逐次递增，random随机）






//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^

var num = Math.floor(Math.random() * 100);
if (confirm("猜数字，是否开始游戏？")) {
    for (var i = 0; i <= 10; i++) {
        var number = prompt("请输入一个1-100中的数字");
        if (number == num) {
            if (i < 6) {
                alert("碉堡了!")
                break;
            } if (i < 8) {
                alert("666!")
                break;
            } else {
                alert("猜到了。")
            }
            break;
        } if (i == 10) {
            alert("^ (*￣(oo) ￣)^")
            break;
        }
        if (number < num) {
            alert("您猜小了！")
        }
        else if (i == 10) {
            alert("^ (*￣(oo) ￣)^")
            break;
        }
        if (number > num) {
            alert("您猜大了！")
        }


    }
}

