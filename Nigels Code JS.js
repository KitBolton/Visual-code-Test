Bridge.assembly("Demo", function ($asm, globals) {
    "use strict";

    Bridge.define("test.Program", {
        main: function Main (args) {
            var prioritycheck;
            System.Console.WriteLine("check priority: ");
            prioritycheck = System.Convert.toInt32(prompt());
            if ((prioritycheck > 0) && (prioritycheck <= 20)) {
                System.Console.WriteLine("you are low priority");
            } else {
                if ((prioritycheck > 20) && (prioritycheck <= 45)) {
                    System.Console.WriteLine("you are medium priority");
                } else {
                    System.Console.WriteLine("you are high priority");
                }
            }

            prompt();
        }
    });
});