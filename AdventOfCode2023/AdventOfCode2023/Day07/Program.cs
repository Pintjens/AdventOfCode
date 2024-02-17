namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now.Ticks;

            string input = "Q4QKK 465\r\n28555 580\r\nJJQK2 602\r\n84448 722\r\n7QQ7Q 734\r\nKKKAK 278\r\nJQ274 574\r\n9J242 805\r\nA33AK 619\r\nTAK9T 659\r\n34QK8 514\r\n23273 199\r\nT8TT8 318\r\n333TT 101\r\n5A955 482\r\nTT5KJ 784\r\n59K37 126\r\nT59TQ 890\r\n3K549 806\r\n37QQ3 655\r\nTJ5T4 958\r\n8Q7KQ 148\r\n888AT 868\r\n4KKKA 67\r\nQQQ8Q 520\r\n555Q5 325\r\n8T4K2 132\r\nK32Q5 399\r\nQQ455 937\r\n55QQQ 592\r\n63T89 220\r\n434Q4 254\r\n88KK8 944\r\n79799 793\r\nKJKKK 725\r\n99J59 70\r\n73777 788\r\n5892A 641\r\nJ8JJJ 26\r\n76676 336\r\n55T5T 354\r\n5755T 431\r\n22299 746\r\n82462 803\r\n3J63J 408\r\n95999 711\r\nQ59K6 511\r\nQKJK4 977\r\nQQKK9 606\r\nQQ9Q9 47\r\nA2TQ5 214\r\n68A88 281\r\nTQA64 453\r\nT4633 648\r\n95959 53\r\n23377 293\r\n39993 844\r\n8QTT8 974\r\n95655 10\r\nAAQ4Q 773\r\n69243 213\r\n44244 953\r\n6297T 850\r\nKAAK4 443\r\nQ77J2 865\r\nJ4A3A 651\r\n3Q7Q7 163\r\n9A28T 129\r\nJ2277 68\r\nAAAAT 568\r\nT33TT 907\r\nKA3Q9 942\r\n67787 21\r\n9TAJA 751\r\nK6KKK 485\r\n5T4J5 900\r\n3TKTK 207\r\n4KQQ4 961\r\nTTQ4T 613\r\nK6TQ4 906\r\nA8K8Q 965\r\n63QJ5 807\r\n597Q7 634\r\n64664 723\r\n63479 505\r\nJQQ7Q 870\r\nJT888 185\r\n7JTQ8 650\r\n9888J 7\r\n6646T 405\r\n9J66J 140\r\n2JT22 194\r\nK5KKK 361\r\nT7T79 274\r\n33535 758\r\n27638 314\r\n99699 49\r\nK2QQQ 351\r\n2K72K 92\r\nJ63KK 702\r\nJ7KT5 795\r\nJ6KJ5 770\r\n97K99 928\r\nK376Q 139\r\n882AT 34\r\nKK8K8 995\r\n98AQA 894\r\n5928Q 364\r\nAA6A5 633\r\nT96Q4 249\r\n96696 567\r\nAQ9A5 855\r\nQ6Q44 335\r\n6K2A8 763\r\n7665Q 295\r\nJ7364 89\r\n88848 875\r\n285K3 623\r\n6932T 735\r\n999T6 484\r\n77888 903\r\nJ8888 261\r\n324A2 610\r\nQ6Q53 662\r\n83QTQ 499\r\nJ6666 256\r\n5Q5Q2 507\r\nT6A4K 787\r\nJ5AT5 210\r\nAQ39Q 400\r\n8K6K2 331\r\nJ3Q44 280\r\nKK8KK 926\r\n66784 923\r\n87K88 142\r\n7J235 445\r\n4QQ44 676\r\n84KKK 30\r\n65J56 169\r\n3AA3A 631\r\nQTQ4Q 760\r\nA5A5J 342\r\n5QT5T 674\r\n9K549 776\r\nT2232 343\r\n96Q66 616\r\n8J899 597\r\nJ76A6 116\r\n77388 321\r\n53333 433\r\nKK797 394\r\n9J53Q 545\r\n5K9KK 985\r\n66868 874\r\nJ6T63 654\r\n9A333 696\r\n678JJ 738\r\nAATAT 812\r\nAAT6J 801\r\nJTTQK 441\r\n75757 993\r\nJQ4QQ 523\r\n222JJ 671\r\nQ5552 459\r\n944J9 133\r\n69A8A 588\r\nA75K6 872\r\nKKK44 661\r\n2K43Q 83\r\n3KKKK 350\r\n47773 887\r\n35858 710\r\nK65T9 731\r\nATQ8J 496\r\n8K484 397\r\nTT9QT 157\r\n2J332 630\r\n5K3K4 743\r\n68J26 135\r\n555J5 975\r\nK4KQT 452\r\nQAAAA 884\r\n8J4J9 398\r\n4TJ77 679\r\n55585 93\r\nJ9A4T 182\r\n42942 503\r\n5JK2A 151\r\n2T2K7 672\r\n4Q2T5 563\r\n22422 291\r\n28868 947\r\nKT7KK 759\r\nJQQ88 31\r\n8273K 54\r\n55588 418\r\n5K28K 849\r\n2Q279 896\r\n65995 590\r\n723A4 598\r\n6KA74 127\r\nKK333 284\r\n44696 714\r\n777Q7 277\r\nK469A 673\r\n433QJ 862\r\nA4442 512\r\n66624 665\r\n8AA88 536\r\n7777J 268\r\nA7575 586\r\n7K42Q 789\r\n6A32A 159\r\nT97Q6 218\r\nKJA5J 108\r\n363AJ 510\r\n4JAT7 960\r\n88898 534\r\n2Q2J7 383\r\n57A9T 852\r\nTJ9TQ 750\r\n9T748 775\r\nQTA83 13\r\n4KK5K 701\r\nQ8482 72\r\n66655 109\r\n6TTTT 381\r\nA33JA 779\r\n62AAA 968\r\n3KA2Q 924\r\n2J54A 444\r\n6A285 886\r\n63697 595\r\n459QA 134\r\nJK5KQ 41\r\n34628 231\r\n94544 446\r\nK6JK6 824\r\nKKTT6 815\r\n22229 327\r\n88TT8 916\r\nK6J56 2\r\nT7A73 945\r\n2J222 555\r\n727T2 106\r\nK5664 390\r\nKJ77Q 326\r\n555A5 272\r\n55757 943\r\n33447 128\r\n4A37Q 462\r\n7JJ2T 609\r\n5T2T5 920\r\n49932 219\r\n9J297 221\r\nQK2J2 332\r\nJ23KK 745\r\n8A5K4 854\r\n374K5 371\r\n35Q7T 663\r\n666T6 721\r\n9K9Q3 842\r\nJ55J2 73\r\nAT6AA 969\r\n2TAQK 689\r\nKQ9QQ 486\r\n99KJ9 996\r\n4894Q 774\r\nT9J8Q 61\r\nTK6T6 488\r\n7777K 226\r\n77767 922\r\nK5QK8 12\r\n45444 740\r\n4A448 752\r\nA8793 426\r\n3393J 771\r\n7JTTT 830\r\n434J9 938\r\n66656 470\r\n6JJ66 333\r\n444J4 170\r\n33JJJ 800\r\nQ2K79 467\r\n254JK 757\r\n9994Q 186\r\n94499 804\r\nJ86K6 908\r\nJ8K8K 946\r\n4276T 164\r\nK9QAA 695\r\n779AT 519\r\n7K463 660\r\n55454 208\r\nKK8K9 339\r\nQJJK9 146\r\n6K3J6 538\r\n38T79 732\r\n6QQ6Q 474\r\nQ8J4K 299\r\n99T99 475\r\n3JK42 87\r\nT8Q8J 107\r\nQ4QQK 682\r\n3J333 811\r\n54662 744\r\nJJ4J2 972\r\n2QA87 473\r\n249TK 51\r\n65JA9 251\r\nAAA6A 871\r\nQTT73 222\r\n44J45 670\r\n47747 3\r\n2T299 604\r\n9A922 122\r\n4T428 359\r\n4744T 814\r\n944QQ 532\r\n28JA8 522\r\nJJJJJ 230\r\n88432 910\r\nK6TAJ 315\r\nK7AA3 544\r\n6729J 600\r\n95QQQ 300\r\nT7J77 976\r\nJ448T 587\r\n72J58 412\r\nT8888 168\r\n83333 450\r\n98Q9T 298\r\n5249Q 352\r\n58656 558\r\n347JA 579\r\n27222 893\r\n4QK82 131\r\n5TTT8 994\r\n43494 454\r\n474TT 458\r\n22338 728\r\n77AJ8 562\r\n86633 410\r\nQ7J5A 501\r\n955J2 242\r\nQQQ79 835\r\nATAQT 525\r\nA5AAA 178\r\n39287 289\r\nKTKQK 845\r\n364K2 449\r\nAK3A2 259\r\n627J2 138\r\nK8K82 285\r\n66669 794\r\n6Q2TA 911\r\nTTJTJ 24\r\nKKK33 997\r\nQKKQK 372\r\n3K7QQ 264\r\n62994 175\r\n3T244 227\r\nQ77K7 14\r\n88568 44\r\n8JT98 404\r\n7277Q 250\r\n66555 529\r\n2KJK2 709\r\n94T85 263\r\nT6652 313\r\n53555 113\r\nJ5T88 432\r\nQ6949 624\r\nTKTA8 202\r\n96667 748\r\n4AAAA 491\r\n4A4K4 329\r\n6252K 998\r\n4Q269 347\r\nQ3QQ3 95\r\n488J6 262\r\n99J9Q 100\r\n82T77 591\r\n35T22 362\r\nQ7KQQ 691\r\nA56A5 22\r\n649Q4 898\r\n53J22 301\r\nJ4Q5Q 569\r\n585QJ 81\r\n82528 495\r\nK6TTT 32\r\nQ2222 737\r\n2Q5T5 990\r\nQ888Q 341\r\n8Q866 416\r\n4449A 508\r\n88KQQ 819\r\nAA274 879\r\nK8Q88 160\r\n26TK5 237\r\nJJQQQ 492\r\nK52QA 490\r\nJJ974 223\r\n7T846 136\r\n32236 820\r\n9AJ9A 239\r\nJ6QQQ 380\r\n97Q94 970\r\n56552 856\r\n6QQTQ 905\r\nJJ5AA 837\r\nK9TT9 103\r\n8A9TA 267\r\nJ8AA4 196\r\n2ATAQ 897\r\nJQTJQ 279\r\nTTT2T 699\r\nT2TJ2 966\r\nJJ5J5 294\r\nJ4K4K 60\r\n63KKK 768\r\nAAAA7 38\r\nK4J44 502\r\n23493 888\r\n666KK 831\r\nTAQ58 434\r\nAK75T 319\r\n565A8 769\r\n58K88 705\r\n97579 506\r\nTTQTT 120\r\n5QQJ8 77\r\n55KJ5 328\r\nQ6T3T 375\r\nKQ9T6 476\r\n9K777 305\r\nTT5TT 581\r\n5557K 955\r\n69869 91\r\nQ6925 367\r\n9624J 530\r\n9A9A2 550\r\n5854J 71\r\nT588T 857\r\n74QA4 1\r\n5TJ83 956\r\nT797J 413\r\nT6534 935\r\nT93T3 162\r\n7A488 859\r\n737A3 19\r\n72877 195\r\n3QAAA 78\r\n44449 927\r\n77792 420\r\n43227 537\r\nK986T 84\r\n3J444 754\r\n83AA5 436\r\n89T55 553\r\n86JT6 603\r\nJ22JT 461\r\nKQ8QQ 309\r\n82292 43\r\nJ6QQA 211\r\nT986J 62\r\n38383 382\r\n4AQ6Q 614\r\n2223J 42\r\n8T36A 435\r\nJTTAT 66\r\n44QJQ 829\r\n9TTTT 236\r\nJAJ4A 959\r\n4QJ4J 621\r\n34333 235\r\nQ2Q79 245\r\nQ2A22 388\r\nQQ44Q 635\r\n58A54 539\r\n26A87 440\r\n727A9 149\r\nJ33Q6 406\r\n6479T 627\r\nKK66K 419\r\n3333T 664\r\nKK9KK 317\r\nJ2Q2Q 306\r\nK5K5K 201\r\n44224 63\r\n6644J 322\r\nQQQ3J 96\r\nA4AK4 212\r\nK46JQ 557\r\nJ656J 608\r\nJAJAA 584\r\nK5KK8 615\r\nAAAA2 889\r\nT6T66 478\r\nQQTJ3 494\r\n5QQ75 16\r\n492QJ 909\r\nJKK9K 411\r\n346KQ 144\r\nJ27A7 403\r\n88QQ4 707\r\nT6579 866\r\nTT669 358\r\nTKT84 847\r\nQAJQ4 848\r\n9J9JA 229\r\n3443A 479\r\n455J3 154\r\n43QQ3 762\r\nA9449 246\r\nJK666 417\r\n5588J 448\r\n5KAQ3 427\r\n62A47 58\r\nK4Q74 632\r\n9999Q 468\r\n37537 785\r\n8KT74 166\r\nK93Q2 428\r\n2QQ5Q 688\r\nA6A22 873\r\n5986A 424\r\n74T36 677\r\nJ3958 46\r\n4J4Q4 451\r\n64654 863\r\n58TK3 409\r\nJK6KJ 348\r\nQ8QQJ 666\r\nQQQ53 35\r\nJAK28 839\r\n6KKJK 713\r\n23567 792\r\nQQ5QQ 147\r\nJ9447 582\r\n77QQ7 963\r\n4T84K 204\r\n44747 583\r\nK858Q 307\r\n76J5A 542\r\nA57Q8 180\r\n22262 252\r\n7J689 105\r\n44844 836\r\n76674 23\r\n7A22A 29\r\n7JT56 570\r\n7857J 456\r\n9Q685 215\r\n83878 190\r\n277A7 172\r\nT5T5T 500\r\n64464 477\r\n4T445 65\r\nA43Q9 152\r\nJT5J7 310\r\nTTK55 715\r\n7K85J 365\r\n4A4AA 98\r\nQ68QJ 952\r\n6T266 929\r\n2442T 629\r\n6A776 119\r\nQ57K2 369\r\n555JJ 187\r\n525TJ 438\r\nQ99K7 980\r\nQ9888 657\r\n85854 967\r\nQK85T 930\r\n332A3 667\r\nQJQQQ 243\r\nAAAA3 121\r\n44TQT 270\r\nK35T6 637\r\nTJ7Q7 559\r\nTJT85 797\r\nJ6J25 853\r\nJ6348 593\r\n7T6T7 498\r\nJ222Q 877\r\nQ4QQQ 112\r\nQ93KQ 117\r\n48934 258\r\n44465 817\r\nAA66A 253\r\nTJTT2 167\r\nK67QK 384\r\nT2292 430\r\n77337 344\r\nT99J8 192\r\n334J4 982\r\n2J939 833\r\n23229 353\r\nTJ6Q5 912\r\n36T8K 755\r\n2822J 535\r\n48446 5\r\nA8QA5 988\r\n4J464 130\r\nK9K88 694\r\nA4777 266\r\n888T9 17\r\n33QQ3 639\r\n67868 643\r\nT78T7 248\r\n6382Q 577\r\n444Q7 596\r\n2222K 981\r\n99KK4 288\r\nTJ4T4 575\r\nQTJTT 99\r\n33QAA 97\r\n525J5 189\r\n24QQ3 864\r\n8465J 936\r\nT48KA 571\r\nJT9TT 255\r\n6Q6J8 517\r\n24999 387\r\nTKAQJ 687\r\n93944 914\r\nJT4Q3 158\r\nT76QT 481\r\n48T9Q 225\r\nJJA6J 141\r\n95555 549\r\n4JK37 686\r\n62662 197\r\n68QA7 566\r\nJ3742 747\r\nJ8K9K 287\r\nQJ4J3 638\r\nAAKKK 607\r\n72A6T 948\r\nJK2KK 878\r\n67337 978\r\nTT8TT 895\r\nA8A8A 181\r\n4K977 939\r\nK44AQ 102\r\n5T264 33\r\n54TQK 183\r\n6K666 340\r\nKT9KK 366\r\n3QQ9Q 742\r\n5K829 311\r\n2KK77 576\r\n67A9Q 589\r\nJ4A5Q 712\r\n8ATTJ 345\r\nKK339 9\r\n774J9 698\r\n69996 652\r\nKQQKQ 548\r\n43339 188\r\nJ6585 681\r\n62253 979\r\n99J47 8\r\n32522 425\r\nK43KQ 115\r\n33Q33 483\r\n55AA5 636\r\n48Q54 973\r\nQ55QJ 184\r\n9TTQ9 203\r\n3J733 546\r\n339JJ 556\r\nJ62J2 48\r\nJT4Q5 780\r\n99AA9 25\r\nKKJQJ 275\r\n75A42 273\r\nQKTJ5 232\r\n4JJ4T 808\r\n7647K 786\r\n22522 876\r\n76737 599\r\nJ8858 217\r\n9Q45T 153\r\n8JT2K 493\r\n26634 913\r\n7QJTA 302\r\nKK998 645\r\n49TT8 840\r\nT22T6 904\r\n9AK2A 899\r\n3TQ7J 304\r\n3A48Q 376\r\n33TTJ 720\r\n246A6 983\r\n9TJ32 224\r\n35343 605\r\nJ4AQA 269\r\n332T8 692\r\nKK9K9 949\r\n87KJ8 917\r\n56KK8 303\r\n76K52 933\r\nAAJA2 82\r\n38339 915\r\nJ2299 391\r\n677J7 826\r\nA22TA 316\r\n69J6T 123\r\n9JJ99 437\r\nJ5624 730\r\nQ7QT7 292\r\n5Q9QJ 547\r\nK876J 541\r\n7JJ44 377\r\nK2435 901\r\nTK64T 228\r\n8878J 902\r\n99989 193\r\n222TT 708\r\nQQ88Q 813\r\n59294 668\r\nTKTKJ 50\r\nKQ893 932\r\n3557T 265\r\n7A396 110\r\nQ8888 85\r\n36663 447\r\n87A99 818\r\n7442J 37\r\nTQ4T5 622\r\n45J7J 20\r\nQ6697 414\r\n2226Q 892\r\nQ7QQQ 233\r\n5J395 429\r\n22KJ6 986\r\n662K6 94\r\nJ7398 783\r\nAQJA8 843\r\n78K8K 716\r\nQ4QTK 810\r\nJ54J5 885\r\n32223 238\r\n97776 594\r\n33693 69\r\n47T2Q 286\r\n2QA52 781\r\nQ4J22 761\r\n99A6A 685\r\n9A999 11\r\n444Q4 200\r\nTAK95 56\r\n7Q363 528\r\nKA99J 809\r\nQQTQQ 991\r\n2KAK2 4\r\n599K8 28\r\nTT27T 717\r\n22525 165\r\n78222 349\r\nA6667 838\r\n3Q39T 393\r\n87868 741\r\n8AAJK 513\r\nTQ555 543\r\n79777 925\r\n866J6 560\r\n72788 931\r\n23TTT 374\r\nAA66T 772\r\nK75K4 356\r\nJ6JKJ 509\r\nK3K4J 891\r\n44443 276\r\nK8A88 611\r\n8483A 753\r\nKKKJJ 312\r\nAA6JA 463\r\nK9TKT 704\r\nJTT66 296\r\n6A987 869\r\n22232 951\r\n7K9A7 385\r\nK2223 987\r\nQ24AJ 554\r\n766J8 240\r\n8Q9JA 114\r\n7AKJ9 736\r\nQQ9QQ 851\r\n28AA2 124\r\n3939K 179\r\n3K284 324\r\n94K3J 964\r\n63333 883\r\n89J45 143\r\n8J2T2 471\r\nTT5QK 719\r\nJKQKQ 823\r\nA2898 407\r\n4AK94 565\r\nK889J 260\r\n8KQQT 950\r\n59K59 104\r\nAA7TA 487\r\n36666 308\r\nT64TJ 573\r\n6864J 626\r\n6Q4QQ 703\r\nAAQA4 75\r\n9KJ9Q 649\r\n26J22 257\r\n99889 989\r\nKJTTT 881\r\n83TK9 79\r\n82828 765\r\nKKQK6 552\r\nJ5JQQ 683\r\nA9A98 457\r\nKKK2K 290\r\n49999 464\r\n64QTJ 706\r\n88Q7Q 55\r\n23233 118\r\n37333 739\r\nQTQTT 378\r\nAT8T7 767\r\nA687A 421\r\n9A63T 15\r\n325J9 749\r\nK7966 921\r\nAAAKK 489\r\n29829 675\r\n7377A 455\r\nKJ3KK 57\r\n4QT2K 36\r\nJ7384 718\r\nK3K77 656\r\nQ4J85 442\r\n53AK9 39\r\n53782 766\r\nQ4545 572\r\n522TJ 330\r\nJ4J42 472\r\nJA56A 497\r\n64534 137\r\n4J322 27\r\n57777 111\r\nTT338 828\r\n44J4J 984\r\n8AAAA 612\r\nJ7Q25 821\r\nQ7J57 368\r\n88289 415\r\n888JJ 646\r\n36833 727\r\nT9TT2 271\r\n44A88 802\r\nK33J2 155\r\nQ3TQT 59\r\nAK755 524\r\n3J3J2 346\r\nAJ3TA 941\r\n9635K 357\r\n499JJ 234\r\nQ8884 337\r\nJ8QJ8 678\r\n3333A 860\r\nTT775 480\r\nAATAQ 882\r\n5QQAA 247\r\n95833 80\r\n3TTQ8 690\r\nT32TJ 934\r\nQAQQ6 370\r\nA9998 684\r\nKTJ37 585\r\n52JKJ 320\r\n879A8 640\r\n7KJ77 161\r\n9QQAA 216\r\n32J6T 373\r\n389A5 76\r\nT988T 282\r\n86865 518\r\n45K45 578\r\n8288T 796\r\n96524 297\r\n78J55 625\r\nQJQKT 954\r\nJ4353 334\r\n37KAJ 86\r\n4J9TQ 401\r\nQ674K 940\r\nQQKQQ 617\r\nA2356 460\r\n2A38K 825\r\nQ3TQ2 45\r\n57AJ3 790\r\n3A7J7 841\r\nA43A4 669\r\n24AJ3 653\r\n68666 466\r\n33793 88\r\n9J999 439\r\n5J577 389\r\n9Q7J6 173\r\nQ5T8T 540\r\nA7AT7 531\r\nT99TT 206\r\n565A5 858\r\n7935J 561\r\nA593Q 861\r\n898A9 18\r\nA8887 392\r\n424J2 40\r\n36336 867\r\n7J577 205\r\n5JJ43 386\r\nTTTTJ 693\r\nQT624 628\r\nA7TT7 832\r\nK44K5 150\r\n3J35Q 198\r\n9T29A 726\r\nKK5J7 423\r\nAAJAT 396\r\n37J7K 764\r\n7TTT7 971\r\n7K63A 647\r\nTT66T 515\r\n4644A 798\r\nTJ944 177\r\n2J6K9 323\r\n47674 880\r\nAAJAA 379\r\n86884 74\r\n6J366 64\r\nATQ2T 469\r\n7J9QK 680\r\nTATT7 782\r\nQ7QQ4 52\r\n52555 816\r\nAA9A5 156\r\nK2K8T 283\r\n278J8 724\r\n95Q55 360\r\n3K332 516\r\n7Q5A3 125\r\nTAATT 733\r\n2K44K 363\r\n58K74 601\r\n7J77J 919\r\n4474J 191\r\n7T4JJ 521\r\n22A6K 620\r\n33T3J 244\r\nJTAJT 551\r\n879Q5 338\r\n67324 1000\r\nJJ333 918\r\n887AA 957\r\nQTAKK 504\r\n22A22 999\r\nA336A 700\r\n4J93T 729\r\nK5555 992\r\nQTTAJ 846\r\nQT59A 791\r\n42J4A 145\r\nJKK9T 526\r\nJA887 658\r\nJ2255 618\r\nJQJ3Q 6\r\n6A4JT 176\r\n683J8 171\r\nA66Q6 533\r\nQ268J 527\r\n8Q2K9 241\r\n792T2 778\r\nQJJQA 402\r\nAAT24 827\r\nA75AA 697\r\n99444 209\r\nAKA99 799\r\n77667 777\r\n52275 962\r\n7688K 422\r\n72689 174\r\n99929 395\r\nTJ444 642\r\n22Q2Q 90\r\nAJ447 834\r\n58545 564\r\nJT5J4 756\r\n86888 822\r\n9A563 644\r\n666QQ 355";
            string demo = "32T3K 765\r\nT55J5 684\r\nKK677 28\r\nKTJJT 220\r\nQQQJA 483";

            string temp = input;

            List<CamelHand> allHands = new List<CamelHand>();
            var temp2 = temp.Split("\r\n");
            foreach (var line in temp2)
            {
                string[] handparts = line.Split(' ');
                handparts[0] = handparts[0].Replace("K", "B").Replace("Q", "C").Replace('J', 'Z').Replace("T", "E").Replace("9", "F").Replace("8", "G").Replace("7", "H").Replace("6", "I").Replace("5", "J").Replace("4", "K").Replace("3", "L").Replace("2", "M").Replace("1", "N");
                CamelHand newHand = new CamelHand() { hand = handparts[0], bid = Convert.ToInt32(handparts[1]) };
                allHands.Add(newHand);
            }



            List<CamelHand> VoAk = new List<CamelHand>();
            List<CamelHand> FoAk = new List<CamelHand>();
            List<CamelHand> FH = new List<CamelHand>();
            List<CamelHand> ToAk = new List<CamelHand>();
            List<CamelHand> TwoP = new List<CamelHand>();
            List<CamelHand> OneP = new List<CamelHand>();
            List<CamelHand> HC = new List<CamelHand>();
            int debug = 0;
            foreach (var hand in allHands)
            {
                debug++;
                var destinct = hand.hand.Distinct().ToList();
                var j = destinct.Count();


                int x = 0;

                switch (j)
                {
                    case 1:
                        VoAk.Add(hand);
                        break;
                    case 2:
                        //FH or FoAk
                        //if (hand.hand.Remove(destinct[0]).Count() == 4 || hand.hand.Remove(destinct[1]).Count() == 4)
                        //{
                        //    FoAk.Add(hand);
                        //}

                        if (destinct.Contains('Z'))
                        {
                            VoAk.Add(hand);
                            break;
                        }

                        foreach (var option in destinct)
                        {
                            x = 0;
                            foreach (var c in hand.hand)
                            {
                                if (c.Equals(option))
                                {
                                    x++;
                                }
                            }
                            if (x == 4)
                            {
                                FoAk.Add(hand);
                                break;
                            }
                        }
                        if (x != 4)
                        {
                            FH.Add(hand);
                        }

                        break;
                    case 3:
                        //ToAk or TwoP
                        //if (hand.hand.Remove(destinct[0]).Count() == 3 || hand.hand.Remove(destinct[1]).Count() == 3 || hand.hand.Remove(destinct[2]).Count() == 3)

                        //if (hand.hand.Remove(destinct[0]).Count() == 2 || hand.hand.Remove(destinct[1]).Count() == 2 || hand.hand.Remove(destinct[2]).Count() == 2)

                        x = 0;
                        foreach (var option in destinct)
                        {
                            x = 0;
                            foreach (var c in hand.hand)
                            {
                                if (c.Equals(option))
                                {
                                    x++;
                                }
                            }
                            if (x == 3)
                            {
                                //FoAk?
                                if (destinct.Contains('Z'))
                                {
                                    FoAk.Add(hand);
                                    break;
                                }
                                else
                                {

                                    ToAk.Add(hand);
                                    break;
                                }
                            }
                        }
                        if (x != 3) // At least Two Pair
                        {
                            //More?
                            if (destinct.Contains('Z'))
                            {
                                // 4 of a kind or full house?

                                x = 0;
                                foreach (var c in hand.hand)
                                {
                                    if (c.Equals('Z'))
                                    {
                                        x++;
                                    }
                                }
                                if (x == 1)
                                {
                                    FH.Add(hand);
                                }
                                else
                                {
                                    FoAk.Add(hand);

                                }



                            }
                            else
                            {
                                TwoP.Add(hand);
                            }
                        }
                        break;
                    case 4:
                        if (destinct.Contains('Z'))
                        {
                            ToAk.Add(hand);

                        }
                        else
                        {
                            OneP.Add(hand);
                        }
                        break;

                    default:
                        if (destinct.Contains('Z'))
                        {
                            OneP.Add(hand);

                        }
                        else
                        {
                            HC.Add(hand);

                        }
                        break;
                }
            }



            HC.Sort();
            OneP.Sort();
            TwoP.Sort();
            ToAk.Sort();
            FH.Sort();
            FoAk.Sort();
            VoAk.Sort();


            List<List<CamelHand>> camelHands = new List<List<CamelHand>>();
            camelHands.Add(HC);
            camelHands.Add(OneP);
            camelHands.Add(TwoP);
            camelHands.Add(ToAk);
            camelHands.Add(FH);
            camelHands.Add(FoAk);
            camelHands.Add(VoAk);

            long total = 0;
            long rank = 0;

            foreach (var c in camelHands)
            {
                foreach (var hand in c)
                {
                    rank++;
                    total += (long)hand.bid * rank;
                }
            }



            var end = DateTime.Now.Ticks;
            Console.WriteLine(total);
            Console.WriteLine($"In: {end - start}");

            // 249397532 to low 2
            // 249368152 to low 2 obviously
            // 249400220 is right

            // IN
            // 65 000 base

        }
        static void Solved(string[] args)
        {
            var start = DateTime.Now.Ticks;

            string input = "Q4QKK 465\r\n28555 580\r\nJJQK2 602\r\n84448 722\r\n7QQ7Q 734\r\nKKKAK 278\r\nJQ274 574\r\n9J242 805\r\nA33AK 619\r\nTAK9T 659\r\n34QK8 514\r\n23273 199\r\nT8TT8 318\r\n333TT 101\r\n5A955 482\r\nTT5KJ 784\r\n59K37 126\r\nT59TQ 890\r\n3K549 806\r\n37QQ3 655\r\nTJ5T4 958\r\n8Q7KQ 148\r\n888AT 868\r\n4KKKA 67\r\nQQQ8Q 520\r\n555Q5 325\r\n8T4K2 132\r\nK32Q5 399\r\nQQ455 937\r\n55QQQ 592\r\n63T89 220\r\n434Q4 254\r\n88KK8 944\r\n79799 793\r\nKJKKK 725\r\n99J59 70\r\n73777 788\r\n5892A 641\r\nJ8JJJ 26\r\n76676 336\r\n55T5T 354\r\n5755T 431\r\n22299 746\r\n82462 803\r\n3J63J 408\r\n95999 711\r\nQ59K6 511\r\nQKJK4 977\r\nQQKK9 606\r\nQQ9Q9 47\r\nA2TQ5 214\r\n68A88 281\r\nTQA64 453\r\nT4633 648\r\n95959 53\r\n23377 293\r\n39993 844\r\n8QTT8 974\r\n95655 10\r\nAAQ4Q 773\r\n69243 213\r\n44244 953\r\n6297T 850\r\nKAAK4 443\r\nQ77J2 865\r\nJ4A3A 651\r\n3Q7Q7 163\r\n9A28T 129\r\nJ2277 68\r\nAAAAT 568\r\nT33TT 907\r\nKA3Q9 942\r\n67787 21\r\n9TAJA 751\r\nK6KKK 485\r\n5T4J5 900\r\n3TKTK 207\r\n4KQQ4 961\r\nTTQ4T 613\r\nK6TQ4 906\r\nA8K8Q 965\r\n63QJ5 807\r\n597Q7 634\r\n64664 723\r\n63479 505\r\nJQQ7Q 870\r\nJT888 185\r\n7JTQ8 650\r\n9888J 7\r\n6646T 405\r\n9J66J 140\r\n2JT22 194\r\nK5KKK 361\r\nT7T79 274\r\n33535 758\r\n27638 314\r\n99699 49\r\nK2QQQ 351\r\n2K72K 92\r\nJ63KK 702\r\nJ7KT5 795\r\nJ6KJ5 770\r\n97K99 928\r\nK376Q 139\r\n882AT 34\r\nKK8K8 995\r\n98AQA 894\r\n5928Q 364\r\nAA6A5 633\r\nT96Q4 249\r\n96696 567\r\nAQ9A5 855\r\nQ6Q44 335\r\n6K2A8 763\r\n7665Q 295\r\nJ7364 89\r\n88848 875\r\n285K3 623\r\n6932T 735\r\n999T6 484\r\n77888 903\r\nJ8888 261\r\n324A2 610\r\nQ6Q53 662\r\n83QTQ 499\r\nJ6666 256\r\n5Q5Q2 507\r\nT6A4K 787\r\nJ5AT5 210\r\nAQ39Q 400\r\n8K6K2 331\r\nJ3Q44 280\r\nKK8KK 926\r\n66784 923\r\n87K88 142\r\n7J235 445\r\n4QQ44 676\r\n84KKK 30\r\n65J56 169\r\n3AA3A 631\r\nQTQ4Q 760\r\nA5A5J 342\r\n5QT5T 674\r\n9K549 776\r\nT2232 343\r\n96Q66 616\r\n8J899 597\r\nJ76A6 116\r\n77388 321\r\n53333 433\r\nKK797 394\r\n9J53Q 545\r\n5K9KK 985\r\n66868 874\r\nJ6T63 654\r\n9A333 696\r\n678JJ 738\r\nAATAT 812\r\nAAT6J 801\r\nJTTQK 441\r\n75757 993\r\nJQ4QQ 523\r\n222JJ 671\r\nQ5552 459\r\n944J9 133\r\n69A8A 588\r\nA75K6 872\r\nKKK44 661\r\n2K43Q 83\r\n3KKKK 350\r\n47773 887\r\n35858 710\r\nK65T9 731\r\nATQ8J 496\r\n8K484 397\r\nTT9QT 157\r\n2J332 630\r\n5K3K4 743\r\n68J26 135\r\n555J5 975\r\nK4KQT 452\r\nQAAAA 884\r\n8J4J9 398\r\n4TJ77 679\r\n55585 93\r\nJ9A4T 182\r\n42942 503\r\n5JK2A 151\r\n2T2K7 672\r\n4Q2T5 563\r\n22422 291\r\n28868 947\r\nKT7KK 759\r\nJQQ88 31\r\n8273K 54\r\n55588 418\r\n5K28K 849\r\n2Q279 896\r\n65995 590\r\n723A4 598\r\n6KA74 127\r\nKK333 284\r\n44696 714\r\n777Q7 277\r\nK469A 673\r\n433QJ 862\r\nA4442 512\r\n66624 665\r\n8AA88 536\r\n7777J 268\r\nA7575 586\r\n7K42Q 789\r\n6A32A 159\r\nT97Q6 218\r\nKJA5J 108\r\n363AJ 510\r\n4JAT7 960\r\n88898 534\r\n2Q2J7 383\r\n57A9T 852\r\nTJ9TQ 750\r\n9T748 775\r\nQTA83 13\r\n4KK5K 701\r\nQ8482 72\r\n66655 109\r\n6TTTT 381\r\nA33JA 779\r\n62AAA 968\r\n3KA2Q 924\r\n2J54A 444\r\n6A285 886\r\n63697 595\r\n459QA 134\r\nJK5KQ 41\r\n34628 231\r\n94544 446\r\nK6JK6 824\r\nKKTT6 815\r\n22229 327\r\n88TT8 916\r\nK6J56 2\r\nT7A73 945\r\n2J222 555\r\n727T2 106\r\nK5664 390\r\nKJ77Q 326\r\n555A5 272\r\n55757 943\r\n33447 128\r\n4A37Q 462\r\n7JJ2T 609\r\n5T2T5 920\r\n49932 219\r\n9J297 221\r\nQK2J2 332\r\nJ23KK 745\r\n8A5K4 854\r\n374K5 371\r\n35Q7T 663\r\n666T6 721\r\n9K9Q3 842\r\nJ55J2 73\r\nAT6AA 969\r\n2TAQK 689\r\nKQ9QQ 486\r\n99KJ9 996\r\n4894Q 774\r\nT9J8Q 61\r\nTK6T6 488\r\n7777K 226\r\n77767 922\r\nK5QK8 12\r\n45444 740\r\n4A448 752\r\nA8793 426\r\n3393J 771\r\n7JTTT 830\r\n434J9 938\r\n66656 470\r\n6JJ66 333\r\n444J4 170\r\n33JJJ 800\r\nQ2K79 467\r\n254JK 757\r\n9994Q 186\r\n94499 804\r\nJ86K6 908\r\nJ8K8K 946\r\n4276T 164\r\nK9QAA 695\r\n779AT 519\r\n7K463 660\r\n55454 208\r\nKK8K9 339\r\nQJJK9 146\r\n6K3J6 538\r\n38T79 732\r\n6QQ6Q 474\r\nQ8J4K 299\r\n99T99 475\r\n3JK42 87\r\nT8Q8J 107\r\nQ4QQK 682\r\n3J333 811\r\n54662 744\r\nJJ4J2 972\r\n2QA87 473\r\n249TK 51\r\n65JA9 251\r\nAAA6A 871\r\nQTT73 222\r\n44J45 670\r\n47747 3\r\n2T299 604\r\n9A922 122\r\n4T428 359\r\n4744T 814\r\n944QQ 532\r\n28JA8 522\r\nJJJJJ 230\r\n88432 910\r\nK6TAJ 315\r\nK7AA3 544\r\n6729J 600\r\n95QQQ 300\r\nT7J77 976\r\nJ448T 587\r\n72J58 412\r\nT8888 168\r\n83333 450\r\n98Q9T 298\r\n5249Q 352\r\n58656 558\r\n347JA 579\r\n27222 893\r\n4QK82 131\r\n5TTT8 994\r\n43494 454\r\n474TT 458\r\n22338 728\r\n77AJ8 562\r\n86633 410\r\nQ7J5A 501\r\n955J2 242\r\nQQQ79 835\r\nATAQT 525\r\nA5AAA 178\r\n39287 289\r\nKTKQK 845\r\n364K2 449\r\nAK3A2 259\r\n627J2 138\r\nK8K82 285\r\n66669 794\r\n6Q2TA 911\r\nTTJTJ 24\r\nKKK33 997\r\nQKKQK 372\r\n3K7QQ 264\r\n62994 175\r\n3T244 227\r\nQ77K7 14\r\n88568 44\r\n8JT98 404\r\n7277Q 250\r\n66555 529\r\n2KJK2 709\r\n94T85 263\r\nT6652 313\r\n53555 113\r\nJ5T88 432\r\nQ6949 624\r\nTKTA8 202\r\n96667 748\r\n4AAAA 491\r\n4A4K4 329\r\n6252K 998\r\n4Q269 347\r\nQ3QQ3 95\r\n488J6 262\r\n99J9Q 100\r\n82T77 591\r\n35T22 362\r\nQ7KQQ 691\r\nA56A5 22\r\n649Q4 898\r\n53J22 301\r\nJ4Q5Q 569\r\n585QJ 81\r\n82528 495\r\nK6TTT 32\r\nQ2222 737\r\n2Q5T5 990\r\nQ888Q 341\r\n8Q866 416\r\n4449A 508\r\n88KQQ 819\r\nAA274 879\r\nK8Q88 160\r\n26TK5 237\r\nJJQQQ 492\r\nK52QA 490\r\nJJ974 223\r\n7T846 136\r\n32236 820\r\n9AJ9A 239\r\nJ6QQQ 380\r\n97Q94 970\r\n56552 856\r\n6QQTQ 905\r\nJJ5AA 837\r\nK9TT9 103\r\n8A9TA 267\r\nJ8AA4 196\r\n2ATAQ 897\r\nJQTJQ 279\r\nTTT2T 699\r\nT2TJ2 966\r\nJJ5J5 294\r\nJ4K4K 60\r\n63KKK 768\r\nAAAA7 38\r\nK4J44 502\r\n23493 888\r\n666KK 831\r\nTAQ58 434\r\nAK75T 319\r\n565A8 769\r\n58K88 705\r\n97579 506\r\nTTQTT 120\r\n5QQJ8 77\r\n55KJ5 328\r\nQ6T3T 375\r\nKQ9T6 476\r\n9K777 305\r\nTT5TT 581\r\n5557K 955\r\n69869 91\r\nQ6925 367\r\n9624J 530\r\n9A9A2 550\r\n5854J 71\r\nT588T 857\r\n74QA4 1\r\n5TJ83 956\r\nT797J 413\r\nT6534 935\r\nT93T3 162\r\n7A488 859\r\n737A3 19\r\n72877 195\r\n3QAAA 78\r\n44449 927\r\n77792 420\r\n43227 537\r\nK986T 84\r\n3J444 754\r\n83AA5 436\r\n89T55 553\r\n86JT6 603\r\nJ22JT 461\r\nKQ8QQ 309\r\n82292 43\r\nJ6QQA 211\r\nT986J 62\r\n38383 382\r\n4AQ6Q 614\r\n2223J 42\r\n8T36A 435\r\nJTTAT 66\r\n44QJQ 829\r\n9TTTT 236\r\nJAJ4A 959\r\n4QJ4J 621\r\n34333 235\r\nQ2Q79 245\r\nQ2A22 388\r\nQQ44Q 635\r\n58A54 539\r\n26A87 440\r\n727A9 149\r\nJ33Q6 406\r\n6479T 627\r\nKK66K 419\r\n3333T 664\r\nKK9KK 317\r\nJ2Q2Q 306\r\nK5K5K 201\r\n44224 63\r\n6644J 322\r\nQQQ3J 96\r\nA4AK4 212\r\nK46JQ 557\r\nJ656J 608\r\nJAJAA 584\r\nK5KK8 615\r\nAAAA2 889\r\nT6T66 478\r\nQQTJ3 494\r\n5QQ75 16\r\n492QJ 909\r\nJKK9K 411\r\n346KQ 144\r\nJ27A7 403\r\n88QQ4 707\r\nT6579 866\r\nTT669 358\r\nTKT84 847\r\nQAJQ4 848\r\n9J9JA 229\r\n3443A 479\r\n455J3 154\r\n43QQ3 762\r\nA9449 246\r\nJK666 417\r\n5588J 448\r\n5KAQ3 427\r\n62A47 58\r\nK4Q74 632\r\n9999Q 468\r\n37537 785\r\n8KT74 166\r\nK93Q2 428\r\n2QQ5Q 688\r\nA6A22 873\r\n5986A 424\r\n74T36 677\r\nJ3958 46\r\n4J4Q4 451\r\n64654 863\r\n58TK3 409\r\nJK6KJ 348\r\nQ8QQJ 666\r\nQQQ53 35\r\nJAK28 839\r\n6KKJK 713\r\n23567 792\r\nQQ5QQ 147\r\nJ9447 582\r\n77QQ7 963\r\n4T84K 204\r\n44747 583\r\nK858Q 307\r\n76J5A 542\r\nA57Q8 180\r\n22262 252\r\n7J689 105\r\n44844 836\r\n76674 23\r\n7A22A 29\r\n7JT56 570\r\n7857J 456\r\n9Q685 215\r\n83878 190\r\n277A7 172\r\nT5T5T 500\r\n64464 477\r\n4T445 65\r\nA43Q9 152\r\nJT5J7 310\r\nTTK55 715\r\n7K85J 365\r\n4A4AA 98\r\nQ68QJ 952\r\n6T266 929\r\n2442T 629\r\n6A776 119\r\nQ57K2 369\r\n555JJ 187\r\n525TJ 438\r\nQ99K7 980\r\nQ9888 657\r\n85854 967\r\nQK85T 930\r\n332A3 667\r\nQJQQQ 243\r\nAAAA3 121\r\n44TQT 270\r\nK35T6 637\r\nTJ7Q7 559\r\nTJT85 797\r\nJ6J25 853\r\nJ6348 593\r\n7T6T7 498\r\nJ222Q 877\r\nQ4QQQ 112\r\nQ93KQ 117\r\n48934 258\r\n44465 817\r\nAA66A 253\r\nTJTT2 167\r\nK67QK 384\r\nT2292 430\r\n77337 344\r\nT99J8 192\r\n334J4 982\r\n2J939 833\r\n23229 353\r\nTJ6Q5 912\r\n36T8K 755\r\n2822J 535\r\n48446 5\r\nA8QA5 988\r\n4J464 130\r\nK9K88 694\r\nA4777 266\r\n888T9 17\r\n33QQ3 639\r\n67868 643\r\nT78T7 248\r\n6382Q 577\r\n444Q7 596\r\n2222K 981\r\n99KK4 288\r\nTJ4T4 575\r\nQTJTT 99\r\n33QAA 97\r\n525J5 189\r\n24QQ3 864\r\n8465J 936\r\nT48KA 571\r\nJT9TT 255\r\n6Q6J8 517\r\n24999 387\r\nTKAQJ 687\r\n93944 914\r\nJT4Q3 158\r\nT76QT 481\r\n48T9Q 225\r\nJJA6J 141\r\n95555 549\r\n4JK37 686\r\n62662 197\r\n68QA7 566\r\nJ3742 747\r\nJ8K9K 287\r\nQJ4J3 638\r\nAAKKK 607\r\n72A6T 948\r\nJK2KK 878\r\n67337 978\r\nTT8TT 895\r\nA8A8A 181\r\n4K977 939\r\nK44AQ 102\r\n5T264 33\r\n54TQK 183\r\n6K666 340\r\nKT9KK 366\r\n3QQ9Q 742\r\n5K829 311\r\n2KK77 576\r\n67A9Q 589\r\nJ4A5Q 712\r\n8ATTJ 345\r\nKK339 9\r\n774J9 698\r\n69996 652\r\nKQQKQ 548\r\n43339 188\r\nJ6585 681\r\n62253 979\r\n99J47 8\r\n32522 425\r\nK43KQ 115\r\n33Q33 483\r\n55AA5 636\r\n48Q54 973\r\nQ55QJ 184\r\n9TTQ9 203\r\n3J733 546\r\n339JJ 556\r\nJ62J2 48\r\nJT4Q5 780\r\n99AA9 25\r\nKKJQJ 275\r\n75A42 273\r\nQKTJ5 232\r\n4JJ4T 808\r\n7647K 786\r\n22522 876\r\n76737 599\r\nJ8858 217\r\n9Q45T 153\r\n8JT2K 493\r\n26634 913\r\n7QJTA 302\r\nKK998 645\r\n49TT8 840\r\nT22T6 904\r\n9AK2A 899\r\n3TQ7J 304\r\n3A48Q 376\r\n33TTJ 720\r\n246A6 983\r\n9TJ32 224\r\n35343 605\r\nJ4AQA 269\r\n332T8 692\r\nKK9K9 949\r\n87KJ8 917\r\n56KK8 303\r\n76K52 933\r\nAAJA2 82\r\n38339 915\r\nJ2299 391\r\n677J7 826\r\nA22TA 316\r\n69J6T 123\r\n9JJ99 437\r\nJ5624 730\r\nQ7QT7 292\r\n5Q9QJ 547\r\nK876J 541\r\n7JJ44 377\r\nK2435 901\r\nTK64T 228\r\n8878J 902\r\n99989 193\r\n222TT 708\r\nQQ88Q 813\r\n59294 668\r\nTKTKJ 50\r\nKQ893 932\r\n3557T 265\r\n7A396 110\r\nQ8888 85\r\n36663 447\r\n87A99 818\r\n7442J 37\r\nTQ4T5 622\r\n45J7J 20\r\nQ6697 414\r\n2226Q 892\r\nQ7QQQ 233\r\n5J395 429\r\n22KJ6 986\r\n662K6 94\r\nJ7398 783\r\nAQJA8 843\r\n78K8K 716\r\nQ4QTK 810\r\nJ54J5 885\r\n32223 238\r\n97776 594\r\n33693 69\r\n47T2Q 286\r\n2QA52 781\r\nQ4J22 761\r\n99A6A 685\r\n9A999 11\r\n444Q4 200\r\nTAK95 56\r\n7Q363 528\r\nKA99J 809\r\nQQTQQ 991\r\n2KAK2 4\r\n599K8 28\r\nTT27T 717\r\n22525 165\r\n78222 349\r\nA6667 838\r\n3Q39T 393\r\n87868 741\r\n8AAJK 513\r\nTQ555 543\r\n79777 925\r\n866J6 560\r\n72788 931\r\n23TTT 374\r\nAA66T 772\r\nK75K4 356\r\nJ6JKJ 509\r\nK3K4J 891\r\n44443 276\r\nK8A88 611\r\n8483A 753\r\nKKKJJ 312\r\nAA6JA 463\r\nK9TKT 704\r\nJTT66 296\r\n6A987 869\r\n22232 951\r\n7K9A7 385\r\nK2223 987\r\nQ24AJ 554\r\n766J8 240\r\n8Q9JA 114\r\n7AKJ9 736\r\nQQ9QQ 851\r\n28AA2 124\r\n3939K 179\r\n3K284 324\r\n94K3J 964\r\n63333 883\r\n89J45 143\r\n8J2T2 471\r\nTT5QK 719\r\nJKQKQ 823\r\nA2898 407\r\n4AK94 565\r\nK889J 260\r\n8KQQT 950\r\n59K59 104\r\nAA7TA 487\r\n36666 308\r\nT64TJ 573\r\n6864J 626\r\n6Q4QQ 703\r\nAAQA4 75\r\n9KJ9Q 649\r\n26J22 257\r\n99889 989\r\nKJTTT 881\r\n83TK9 79\r\n82828 765\r\nKKQK6 552\r\nJ5JQQ 683\r\nA9A98 457\r\nKKK2K 290\r\n49999 464\r\n64QTJ 706\r\n88Q7Q 55\r\n23233 118\r\n37333 739\r\nQTQTT 378\r\nAT8T7 767\r\nA687A 421\r\n9A63T 15\r\n325J9 749\r\nK7966 921\r\nAAAKK 489\r\n29829 675\r\n7377A 455\r\nKJ3KK 57\r\n4QT2K 36\r\nJ7384 718\r\nK3K77 656\r\nQ4J85 442\r\n53AK9 39\r\n53782 766\r\nQ4545 572\r\n522TJ 330\r\nJ4J42 472\r\nJA56A 497\r\n64534 137\r\n4J322 27\r\n57777 111\r\nTT338 828\r\n44J4J 984\r\n8AAAA 612\r\nJ7Q25 821\r\nQ7J57 368\r\n88289 415\r\n888JJ 646\r\n36833 727\r\nT9TT2 271\r\n44A88 802\r\nK33J2 155\r\nQ3TQT 59\r\nAK755 524\r\n3J3J2 346\r\nAJ3TA 941\r\n9635K 357\r\n499JJ 234\r\nQ8884 337\r\nJ8QJ8 678\r\n3333A 860\r\nTT775 480\r\nAATAQ 882\r\n5QQAA 247\r\n95833 80\r\n3TTQ8 690\r\nT32TJ 934\r\nQAQQ6 370\r\nA9998 684\r\nKTJ37 585\r\n52JKJ 320\r\n879A8 640\r\n7KJ77 161\r\n9QQAA 216\r\n32J6T 373\r\n389A5 76\r\nT988T 282\r\n86865 518\r\n45K45 578\r\n8288T 796\r\n96524 297\r\n78J55 625\r\nQJQKT 954\r\nJ4353 334\r\n37KAJ 86\r\n4J9TQ 401\r\nQ674K 940\r\nQQKQQ 617\r\nA2356 460\r\n2A38K 825\r\nQ3TQ2 45\r\n57AJ3 790\r\n3A7J7 841\r\nA43A4 669\r\n24AJ3 653\r\n68666 466\r\n33793 88\r\n9J999 439\r\n5J577 389\r\n9Q7J6 173\r\nQ5T8T 540\r\nA7AT7 531\r\nT99TT 206\r\n565A5 858\r\n7935J 561\r\nA593Q 861\r\n898A9 18\r\nA8887 392\r\n424J2 40\r\n36336 867\r\n7J577 205\r\n5JJ43 386\r\nTTTTJ 693\r\nQT624 628\r\nA7TT7 832\r\nK44K5 150\r\n3J35Q 198\r\n9T29A 726\r\nKK5J7 423\r\nAAJAT 396\r\n37J7K 764\r\n7TTT7 971\r\n7K63A 647\r\nTT66T 515\r\n4644A 798\r\nTJ944 177\r\n2J6K9 323\r\n47674 880\r\nAAJAA 379\r\n86884 74\r\n6J366 64\r\nATQ2T 469\r\n7J9QK 680\r\nTATT7 782\r\nQ7QQ4 52\r\n52555 816\r\nAA9A5 156\r\nK2K8T 283\r\n278J8 724\r\n95Q55 360\r\n3K332 516\r\n7Q5A3 125\r\nTAATT 733\r\n2K44K 363\r\n58K74 601\r\n7J77J 919\r\n4474J 191\r\n7T4JJ 521\r\n22A6K 620\r\n33T3J 244\r\nJTAJT 551\r\n879Q5 338\r\n67324 1000\r\nJJ333 918\r\n887AA 957\r\nQTAKK 504\r\n22A22 999\r\nA336A 700\r\n4J93T 729\r\nK5555 992\r\nQTTAJ 846\r\nQT59A 791\r\n42J4A 145\r\nJKK9T 526\r\nJA887 658\r\nJ2255 618\r\nJQJ3Q 6\r\n6A4JT 176\r\n683J8 171\r\nA66Q6 533\r\nQ268J 527\r\n8Q2K9 241\r\n792T2 778\r\nQJJQA 402\r\nAAT24 827\r\nA75AA 697\r\n99444 209\r\nAKA99 799\r\n77667 777\r\n52275 962\r\n7688K 422\r\n72689 174\r\n99929 395\r\nTJ444 642\r\n22Q2Q 90\r\nAJ447 834\r\n58545 564\r\nJT5J4 756\r\n86888 822\r\n9A563 644\r\n666QQ 355";
            string demo = "32T3K 765\r\nT55J5 684\r\nKK677 28\r\nKTJJT 220\r\nQQQJA 483";

            string temp = input;

            List<CamelHand> allHands = new List<CamelHand>();
            var temp2 = temp.Split("\r\n");
            foreach (var line in temp2)
            {
                string[] handparts = line.Split(' ');
                handparts[0] = handparts[0].Replace("K", "B").Replace("Q", "C").Replace('J', 'Z').Replace("T", "E").Replace("9", "F").Replace("8", "G").Replace("7", "H").Replace("6", "I").Replace("5", "J").Replace("4", "K").Replace("3", "L").Replace("2", "M").Replace("1", "N");
                CamelHand newHand = new CamelHand() { hand = handparts[0], bid = Convert.ToInt32(handparts[1]) };
                allHands.Add(newHand);
            }



            List<CamelHand> VoAk = new List<CamelHand>();
            List<CamelHand> FoAk = new List<CamelHand>();
            List<CamelHand> FH = new List<CamelHand>();
            List<CamelHand> ToAk = new List<CamelHand>();
            List<CamelHand> TwoP = new List<CamelHand>();
            List<CamelHand> OneP = new List<CamelHand>();
            List<CamelHand> HC = new List<CamelHand>();
            int debug = 0;
            foreach (var hand in allHands)
            {
                debug++;
                var destinct = hand.hand.Distinct().ToList();
                var j = destinct.Count();


                int x = 0;

                switch (j)
                {
                    case 1:
                        VoAk.Add(hand);
                        break;
                    case 2:
                        //FH or FoAk
                        //if (hand.hand.Remove(destinct[0]).Count() == 4 || hand.hand.Remove(destinct[1]).Count() == 4)
                        //{
                        //    FoAk.Add(hand);
                        //}

                        if (destinct.Contains('Z'))
                        {
                            VoAk.Add(hand);
                            break;
                        }

                        foreach (var option in destinct)
                        {
                            x = 0;
                            foreach (var c in hand.hand)
                            {
                                if (c.Equals(option))
                                {
                                    x++;
                                }
                            }
                            if (x == 4)
                            {
                                FoAk.Add(hand);
                                break;
                            }
                        }
                        if (x != 4)
                        {
                            FH.Add(hand);
                        }

                        break;
                    case 3:
                        //ToAk or TwoP
                        //if (hand.hand.Remove(destinct[0]).Count() == 3 || hand.hand.Remove(destinct[1]).Count() == 3 || hand.hand.Remove(destinct[2]).Count() == 3)

                        //if (hand.hand.Remove(destinct[0]).Count() == 2 || hand.hand.Remove(destinct[1]).Count() == 2 || hand.hand.Remove(destinct[2]).Count() == 2)

                        x = 0;
                        foreach (var option in destinct)
                        {
                            x = 0;
                            foreach (var c in hand.hand)
                            {
                                if (c.Equals(option))
                                {
                                    x++;
                                }
                            }
                            if (x == 3)
                            {
                                //FoAk?
                                if (destinct.Contains('Z'))
                                {
                                    FoAk.Add(hand);
                                    break;
                                }
                                else
                                {

                                    ToAk.Add(hand);
                                    break;
                                }
                            }
                        }
                        if (x != 3) // At least Two Pair
                        {
                            //More?
                            if (destinct.Contains('Z'))
                            {
                                // 4 of a kind or full house?

                                x = 0;
                                foreach (var c in hand.hand)
                                {
                                    if (c.Equals('Z'))
                                    {
                                        x++;
                                    }
                                }
                                if (x == 1)
                                {
                                    FH.Add(hand);
                                }
                                else
                                {
                                    FoAk.Add(hand);

                                }



                            }
                            else
                            {
                                TwoP.Add(hand);
                            }
                        }
                        break;
                    case 4:
                        if (destinct.Contains('Z'))
                        {
                            ToAk.Add(hand);

                        }
                        else
                        {
                            OneP.Add(hand);
                        }
                        break;

                    default:
                        if (destinct.Contains('Z'))
                        {
                            OneP.Add(hand);

                        }
                        else
                        {
                            HC.Add(hand);

                        }
                        break;
                }
            }



            HC.Sort();
            OneP.Sort();
            TwoP.Sort();
            ToAk.Sort();
            FH.Sort();
            FoAk.Sort();
            VoAk.Sort();


            List<List<CamelHand>> camelHands = new List<List<CamelHand>>();
            camelHands.Add(HC);
            camelHands.Add(OneP);
            camelHands.Add(TwoP);
            camelHands.Add(ToAk);
            camelHands.Add(FH);
            camelHands.Add(FoAk);
            camelHands.Add(VoAk);

            long total = 0;
            long rank = 0;

            foreach (var c in camelHands)
            {
                foreach (var hand in c)
                {
                    rank++;
                    total += (long)hand.bid * rank;
                }
            }



            var end = DateTime.Now.Ticks;
            Console.WriteLine(total);
            Console.WriteLine($"In: {end - start}");

            // 249397532 to low 2
            // 249368152 to low 2 obviously
            // 249400220 is right

            // IN
            // 65 000 base

        }
    }
}
