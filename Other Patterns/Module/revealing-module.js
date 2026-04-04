export function RevealingModule() {
  const innerField = 'Inner value';
  const otherInnerField = [1, 2, 3];

  function actionOne() {
    console.log(innerField);
  }

  function actionTwo() {
    console.log(otherInnerField.join(', '));
  }

  return {
    actionOne,
    actionTwo
  };
}

const myModule = RevealingModule();

myModule.actionOne();
myModule.actionTwo();