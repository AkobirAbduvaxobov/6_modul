export class ItemUpdateModel {
  toDoItemId: number = 0;
  title: string = '';
  description: string = '';
  isCompleted: boolean = false;
  dueDate: Date = new Date();
}