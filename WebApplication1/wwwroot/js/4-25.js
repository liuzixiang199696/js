

//使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：
//第n周，源栈同学random人。（n逐次递增，random随机）
//function settime() {
//    let week = 0;
//    function yuanzhan() {
//        week++;
//        let people = Math.floor(Math.random() * 18);
//        alert("第" + week + "周，源栈同学" + people + "人。");
//        setTimeout(yuanzhan, 1000);
//    }
//    yuanzhan();
//}
//settime();
//setTimeout(yuanzhan, 1000);

//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^


//function MonkeyGuess() {
//    let num = Math.floor(Math.random() * 100);
//    if (confirm("猜数字，是否开始游戏？")) {
//        for (var i = 0; i <= 10; i++) {
//            let number = prompt("请输入一个1-100中的数字");
//            if (number == num) {
//                if (i < 6) {
//                    alert("碉堡了!")
//                    break;
//                } if (i < 8) {
//                    alert("666!")
//                    break;
//                } else {
//                    alert("猜到了。")
//                }
//                break;
//            } if (i == 10) {
//                alert("^ (*￣(oo) ￣)^")
//                break;
//            }
//            if (number < num) {
//                alert("您猜小了！")
//            }
//            else if (i == 10) {
//                alert("^ (*￣(oo) ￣)^")
//                break;
//            }
//            if (number > num) {
//                alert("您猜大了！")
//            }


//        }
//    }

//}
//MonkeyGuess();