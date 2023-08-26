# MoneyApp Api


## Available Routes

### Tasks

- `GET /tasks`: Get all existing tasks.
- `GET /tasks/{taskId}`: Get details of a specific task.
- `POST /tasks`: Create a new task.
- `PUT /tasks/{taskId}`: Update information of an existing task.
- `DELETE /tasks/{taskId}`: Delete a task.

### Taxes

- `GET /taxes`: Get information about taxes.
- `GET /taxes/{taxId}`: Get details of a specific tax.

### Users

- `POST /users`: Register a new user.
- `GET /users/{userId}`: Get information of a registered user.
- `PUT /users/{userId}`: Update information of a registered user.
- `DELETE /users/{userId}`: Delete a registered user.

## Path Parameters

- `{taskId}`: ID of the task.
- `{taxId}`: ID of the tax.
- `{userId}`: ID of the user.

## Usage Examples

### Get all tasks

