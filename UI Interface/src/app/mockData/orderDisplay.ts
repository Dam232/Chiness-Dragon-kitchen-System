import { OrderDataInf } from "./Interfaces/order";

export const OderDisplayMock: OrderDataInf[] = [
  {
    OrdeRreference: "Ref001",
    OrderType: "TakeAway",
    OrderDate : "01-05-2020",
    Status : "Order Ready",
    Menu: [
        {desription : "Sea Food", Qty : 1},
        {desription : "chilli chicket curry", Qty : 2},
        {desription : "Noodles", Qty : 2}
    ]
  },
  {
    OrdeRreference: "Ref002",
    OrderType: "TakeAway",
    OrderDate : "01-05-2020",
    Status : "In Queue",
    Menu: [
        {desription : "Sea Food", Qty : 1},
        {desription : "Sea Food2", Qty : 2}
    ]
  },
  {
    OrdeRreference: "Ref003",
    OrderType: "TakeAway",
    OrderDate : "01-05-2020",
    Status : "Mark Prepared",
    Menu: [
        {desription : "Sea Food", Qty : 1},
        {desription : "Sea Food2", Qty : 2}
    ]
  },
  {
    OrdeRreference: "Ref004",
    OrderType: "TakeAway",
    OrderDate : "01-05-2020",
    Status : "Start Preparing",
    Menu: [
        {desription : "Sea Food", Qty : 1},
        {desription : "Sea Food2", Qty : 2}
    ]
  },
];
