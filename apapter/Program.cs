// 适配器模式定义：使原本因接口不匹配而无法在一起工作的两个类能够一起工作
// 当有动机修改一个已经投产的接口中，适配器模式可能是最合适的模式之一了 
var bestAwesomePerson = new UserInfoAdapter();
bestAwesomePerson.GetUserName();
