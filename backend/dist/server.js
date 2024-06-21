"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const body_parser_1 = __importDefault(require("body-parser"));
const fs_1 = __importDefault(require("fs"));
const path_1 = __importDefault(require("path"));
const app = (0, express_1.default)();
const PORT = 3000;
const dbFilePath = path_1.default.join(__dirname, '../db.json');
app.use(body_parser_1.default.json());
// Utility function to read the database file
const readDatabase = (callback) => {
    fs_1.default.readFile(dbFilePath, 'utf-8', callback);
};
// Utility function to write to the database file
const writeDatabase = (data, callback) => {
    fs_1.default.writeFile(dbFilePath, data, callback);
};
// Read submissions
app.get('/read', (req, res) => {
    readDatabase((err, data) => {
        if (err) {
            console.error('Failed to read database file:', err);
            return res.status(500).json({ error: 'Failed to read database file' });
        }
        try {
            const submissions = JSON.parse(data);
            res.json(submissions);
        }
        catch (parseErr) {
            console.error('Error parsing database file:', parseErr);
            res.status(500).json({ error: 'Error parsing database file' });
        }
    });
});
// Create a new submission
app.post('/create', (req, res) => {
    const newSubmission = req.body;
    readDatabase((err, data) => {
        if (err) {
            console.error('Failed to read database file:', err);
            return res.status(500).json({ error: 'Failed to read database file' });
        }
        try {
            const submissions = JSON.parse(data);
            submissions.push(newSubmission);
            writeDatabase(JSON.stringify(submissions, null, 2), (writeErr) => {
                if (writeErr) {
                    console.error('Failed to save submission:', writeErr);
                    return res.status(500).json({ error: 'Failed to save submission' });
                }
                res.send('Submission saved');
            });
        }
        catch (parseErr) {
            console.error('Error parsing database file:', parseErr);
            res.status(500).json({ error: 'Error parsing database file' });
        }
    });
});
// Update a submission
app.put('/update', (req, res) => {
    const index = parseInt(req.query.index, 10);
    const updatedSubmission = req.body;
    readDatabase((err, data) => {
        if (err) {
            console.error('Failed to read database file:', err);
            return res.status(500).json({ error: 'Failed to read database file' });
        }
        try {
            const submissions = JSON.parse(data);
            if (index >= 0 && index < submissions.length) {
                submissions[index] = updatedSubmission;
                writeDatabase(JSON.stringify(submissions, null, 2), (writeErr) => {
                    if (writeErr) {
                        console.error('Failed to update submission:', writeErr);
                        return res.status(500).json({ error: 'Failed to update submission' });
                    }
                    res.send('Submission updated');
                });
            }
            else {
                res.status(400).json({ error: 'Invalid index' });
            }
        }
        catch (parseErr) {
            console.error('Error parsing database file:', parseErr);
            res.status(500).json({ error: 'Error parsing database file' });
        }
    });
});
// Delete a submission
app.delete('/delete', (req, res) => {
    const index = parseInt(req.query.index, 10);
    readDatabase((err, data) => {
        if (err) {
            console.error('Failed to read database file:', err);
            return res.status(500).json({ error: 'Failed to read database file' });
        }
        try {
            const submissions = JSON.parse(data);
            if (index >= 0 && index < submissions.length) {
                submissions.splice(index, 1);
                writeDatabase(JSON.stringify(submissions, null, 2), (writeErr) => {
                    if (writeErr) {
                        console.error('Failed to delete submission:', writeErr);
                        return res.status(500).json({ error: 'Failed to delete submission' });
                    }
                    res.send('Submission deleted');
                });
            }
            else {
                res.status(400).json({ error: 'Invalid index' });
            }
        }
        catch (parseErr) {
            console.error('Error parsing database file:', parseErr);
            res.status(500).json({ error: 'Error parsing database file' });
        }
    });
});
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
